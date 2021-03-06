﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VatrogasnoDrustvo.Forme;
using VatrogasnoDrustvo.InputForms;
using System.Reflection;
using VatrogasnoDrustvo.Bridge;
using Newtonsoft.Json;
using VatrogasnoDrustvo.Core;
using System.Diagnostics;
using VatrogasnoDrustvo.Forms;
using System.Text.RegularExpressions;

namespace VatrogasnoDrustvo
{
    /// <summary>
    /// User kontrola za tablični prikaz kod ostalih formi.
    /// </summary>
    public partial class TablePanel : UserControl
    {
        private bool admin;
        private string table;

        public TablePanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda za brisanje svih handlera u ostalim kontrolama
        /// </summary>
        /// <param name="c">Kontrola iz kojeg se brišu handleri</param>
        public void RemoveHandlerList(Control c)
        {
            EventHandlerList list = (EventHandlerList)typeof(Control).GetProperty("Events", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(c, null);
            typeof(EventHandlerList).GetMethod("Dispose").Invoke(list, null);
        }

        /// <summary>
        /// Metoda za iniciranje gumbića. Neki gumbići su po zadanim postavkama skriveni
        /// pa ih treba prikazati i dodati im ime i EventHandlera za OnClick event.
        /// </summary>
        /// <param name="btn">Gumbić kojem se dodaje EventHandler</param>
        /// <param name="buttonName">Text koji će pisati na gumbiću</param>
        /// <param name="method">Metoda koja će se pozivat onClick</param>
        private void initButton(Button btn, String buttonName, EventHandler method)
        {
            btn.Text = buttonName;
            btn.Visible = true;
            RemoveHandlerList(btn);
            btn.Click += method;
        }

        /// <summary>
        /// Metoda koja skriva gumbiće koji nisu zadani (ona dva koji nisu Dodaj)
        /// </summary>
        private void hideDegrees()
        {
            btnFirstDegree.Visible = false;
            btnSecondDegree.Visible = false;
        }

        /// <summary>
        /// Metoda koja ažurira tablicu kod pretrage.
        /// </summary>
        /// <param name="searchTerm">Ključna riječ za pretraživanje</param>
        public void UpdateDataGridView(String searchTerm) 
        {
            try
            {
                foreach (DataGridViewRow row in dgvDBData.Rows)
                {
                    bool visible = false;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (new Regex(searchTerm, RegexOptions.IgnoreCase).Match(cell.Value.ToString()).Success)
                        {
                            visible = true;
                            break;
                        }
                    }
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvDBData.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = visible;
                    currencyManager1.ResumeBinding();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        /// <summary>
        /// Metoda za refresh forme koja sadrži DataGridView.
        /// Ovisno o formi koja je otvorena, treba staviti gumbiće da su vidljivi i promjeniti labelu, a ne smijemo zaboraviti
        /// niti EventHandlere na gumbićima koji su se tek postavili u vidljive.
        /// </summary>
        /// <param name="keyword">Naziv tablice koja se želi prikazati</param>
        /// <param name="admin">Vrijednost da li je korisnik admin</param>
        public void RefreshPanel<T>(String keyword, bool admin = false)
        {
            this.admin = admin;
            this.table = keyword;
            RemoveHandlerList(dgvDBData);
            hideDegrees();
            if (admin)
            {
                //ovisno o tablici, pokaži gumbiće
                if (keyword == "Oprema")
                {
                    initButton(btnFirstDegree, "Ispis narudžbi", IspisNarudzbi_Click);
                }
                else if (keyword == "Natjecanja")
                {
                    initButton(btnSecondDegree, "Prijavi se", Prijavi_ekipu_natjecanje_Click);
                }
                else if (keyword == "Narudžbe")
                {
                    initButton(btnSecondDegree, "Dobavljači", Dobavljac_Click);
                }
            }
            else
            {
                //registrirani se može samo prijaviti na natjecanje i pogledat stanje
                if (keyword == "Natjecanja")
                {
                    initButton(btnSecondDegree, "Prijavi se", Prijavi_ekipu_natjecanje_Click);
                    dgvDBData.CellDoubleClick += dgvDBData_SpecialEkipaClick;
                }
                btnDodaj.Visible = false;
            }
            
            lblBase.Text = keyword;
            refreshDataGrid<T>(keyword);
        }

        /// <summary>
        /// Specijalni handler za onclick kod registriranog korisnika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDBData_SpecialEkipaClick(object sender, DataGridViewCellEventArgs e)
        {
            new EkipeForma(new Natjecanje(dgvDBData.Rows[e.RowIndex]), false).ShowDialog();
        }

        /// <summary>
        /// Metoda za ažuriranje DataGridView
        /// </summary>
        /// <param name="keyword">Tablica koja se učitava</param>
        private void refreshDataGrid<T>(string keyword)
        {
            try
            {
                //za read
                dgvDBData.DataSource = JsonConvert.DeserializeObject<List<object>>
                    (new Sender().Receive("http://46.101.122.250/gettable.php?table=" + keyword));
                txtSearch.Text = "";
                if (admin)
                {
                    //za update i delete
                    
                    dgvDBData.KeyDown += dgvDBData_KeyDown<T>;
                    dgvDBData.CellDoubleClick += dgvDBData_CellClick<T>;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Pogreška u dohvaćanju podataka! " + Environment.NewLine + e);
            }
        }

        /// <summary>
        /// Handler za OnKeyPress (delete row)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void dgvDBData_KeyDown<T>(object sender, KeyEventArgs e)
        {
            //pritisak na tipku delete
            if (e.KeyCode == Keys.Delete)
            {
                int pos = dgvDBData.SelectedCells[0].RowIndex;
                string name = dgvDBData.Rows[pos].Cells[1].Value.ToString() + " "
                            + dgvDBData.Rows[pos].Cells[2].Value.ToString() + " "
                            + dgvDBData.Rows[pos].Cells[3].Value.ToString() + " "
                            + dgvDBData.Rows[pos].Cells[4].Value.ToString();
                if (MessageBox.Show("Jeste li sigurni da želite obrisati redak " + name, "Potvrda", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //instanciranje dinamički
                    object toDelete = (T)Activator.CreateInstance(typeof(T), dgvDBData.Rows[pos]);

                    try
                    {
                        //MessageBox.Show(new Sender().Send(toDelete, "http://46.101.122.250/delete.php", typeof(T).ToString()));
                        //šalji što se briše
                        var response = JsonConvert.DeserializeObject<Dictionary<string, object>>
                            (new Sender().Send(toDelete, "http://46.101.122.250/delete.php", typeof(T).ToString()));

                        //obradi odgovor
                        if (bool.Parse(response["passed"].ToString()))
                        {
                            MessageBox.Show("Redak je uspješno obrisan!");
                        }
                        else
                        {
                            MessageBox.Show(response["text"].ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Pogreška kod kontaktiranja servera! " + Environment.NewLine + ex.ToString());
                    }

                    //osvježi pogled
                    this.RefreshPanel<T>(table, admin);
                }
            }
        }

        /// <summary>
        /// Handler za OnClick (update row)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void dgvDBData_CellClick<T>(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dgvDBData.Rows[e.RowIndex];
            
            //parse type i otvori formu prema tipu
            if (typeof(T) == typeof(Vatrogasac))
            {
                new PodaciClana(row).ShowDialog();
            }
            else if (typeof(T) == typeof(Natjecanje))
            {
                new PodaciNatjecanje(row, admin).ShowDialog();
            }
            else if (typeof(T) == typeof(Intervencija))
            {
                new PodaciIntervencije(row).ShowDialog();
            }
            else if (typeof(T) == typeof(Dobavljac))
            {
                new PodaciDobavljaca(row).ShowDialog();
            }
            else if (typeof(T) == typeof(Narudzba))
            {
                new PodaciNarudzbe(row).ShowDialog();
            }
            else if(typeof(T) == typeof(Oprema))
            {
                new PodaciOpreme(row).ShowDialog();
            }

            this.RefreshPanel<T>(table, admin);
        }

        /// <summary>
        /// Otvara se forma s narudžbama kada klikne na gumb Ispis narudžbi u formi za opreme.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IspisNarudzbi_Click(object sender, EventArgs e)
        {
            NarudzbeForma frmNarudzbe = new NarudzbeForma(admin);
            frmNarudzbe.Show();
        }

        /// <summary>
        /// Otvara formu s dobavljačima kada klikne na gumb Dobavljači u formi s narudžbama.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dobavljac_Click(object sender, EventArgs e)
        {
            DobavljaciForma frmDobavljaci = new DobavljaciForma(admin);
            frmDobavljaci.Show();
        }

        /// <summary>
        /// Otvori prijavu na natjecanje kada klikne na gumb prijavi se u formi za natjecanja.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Prijavi_ekipu_natjecanje_Click(object sender, EventArgs e)
        {
            if (dgvDBData.SelectedRows != null)
            {
                PodaciPrijava frmPrijava = new PodaciPrijava(new Natjecanje(dgvDBData.Rows[dgvDBData.CurrentCell.RowIndex]));
                if(!frmPrijava.IsDisposed) frmPrijava.Show();
            }
            
        }

        /// <summary>
        /// Ovo je univerzalni gumbić Dodaj koji se prikazuje na svim formama. Budući da svaka forma
        /// otvara drukčiju formu, onda se parsa labela na vrhu i ovisno o njoj se otvaraju zadane forme.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            RemoveHandlerList(btnDodaj);
            if (lblBase.Text == "Članovi")
            {
                openForm(new PodaciClana());
                RefreshPanel<Vatrogasac>(table, admin);
            }
            else if (lblBase.Text == "Intervencije")
            {
                openForm(new PodaciIntervencije());
                RefreshPanel<Intervencija>(table, admin);
            }
            else if (lblBase.Text == "Oprema")
            {
                openForm(new PodaciOpreme());
                RefreshPanel<Oprema>(table, admin);
            }
            else if (lblBase.Text == "Natjecanja")
            {
                openForm(new PodaciNatjecanje());
                RefreshPanel<Natjecanje>(table, admin);
            }
            else if (lblBase.Text == "Dobavljači") 
            { 
                openForm(new PodaciDobavljaca());
                RefreshPanel<Dobavljac>(table, admin);
            }
            else if(lblBase.Text=="Narudžbe"){
                openForm(new PodaciNarudzbe());
                RefreshPanel<Narudzba>(table,admin);
            }
            btnDodaj.Click += btnDodaj_Click;
        }

        /// <summary>
        /// Metoda koja otvara formu. Zasad ima samo frm.ShowDialog(), ali je odvojena zbog mogućih potreba
        /// da se ne može preći na parent formu dok je ova TopLevel forma otvorena.
        /// </summary>
        /// <param name="frm">Forma koja se otvara</param>
        private void openForm(Form frm)
        {
            frm.ShowDialog();
        }

        /// <summary>
        /// OnTextChange event okida, a ažurira pogled na datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateDataGridView(txtSearch.Text);
        }
    }
}
