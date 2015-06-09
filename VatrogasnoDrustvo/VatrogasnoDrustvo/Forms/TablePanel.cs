using System;
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

namespace VatrogasnoDrustvo
{
    /// <summary>
    /// User kontrola za tablični prikaz kod ostalih formi.
    /// </summary>
    public partial class TablePanel : UserControl
    {
        public TablePanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda koja miče sve EventHandlere iz gumbića. Potrebno jer se svakim pozivom
        /// metode initButton kači EventHandler i tada se otvara više istih prozora.
        /// </summary>
        /// <param name="btn">Gumb s kojeg se brišu Handleri</param>
        private void RemoveAllHandlers(Button btn)
        {
            FieldInfo f1 = typeof(Control).GetField("EventClick", BindingFlags.Static | BindingFlags.NonPublic);
            object obj = f1.GetValue(btn);
            PropertyInfo pi = btn.GetType().GetProperty("Events", BindingFlags.NonPublic | BindingFlags.Instance);
            EventHandlerList list = (EventHandlerList)pi.GetValue(btn, null);
            list.RemoveHandler(obj, list[obj]);
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
            RemoveAllHandlers(btn);
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
        /// Metoda koja ažurira tablicu kod pretrage. TBI
        /// </summary>
        /// <param name="searchTerm">Ključna riječ za pretraživanje</param>
        public void UpdateDataGridView(String searchTerm) 
        { 

        }

        /// <summary>
        /// Metoda za refresh forme koja sadrži DataGridView.
        /// Ovisno o formi koja je otvorena, treba staviti gumbiće da su vidljivi i promjeniti labelu, a ne smijemo zaboraviti
        /// niti EventHandlere na gumbićima koji su se tek postavili u vidljive.
        /// </summary>
        /// <param name="keyword">Naziv tablice koja se želi prikazati</param>
        public void RefreshPanel<T>(String keyword)
        {
            hideDegrees();
            if (keyword == "Oprema")
            { 
                initButton(btnFirstDegree, "Ispis narudžbi", IspisNarudzbi_Click);
            }
            else if (keyword == "Natjecanja")
            {
                initButton(btnFirstDegree, "Prijavi se", Prijavi_ekipu_natjecanje_Click);
            }
            else if (keyword == "Narudžbe")
            {
                initButton(btnFirstDegree, "Generiraj PDF", null);
                initButton(btnSecondDegree, "Dobavljači", Dobavljac_Click);
            }
            lblBase.Text = keyword;
            refreshDataGrid<T>(keyword);
        }

        /// <summary>
        /// Metoda za ažuriranje DataGridView
        /// </summary>
        /// <param name="keyword">Tablica koja se učitava</param>
        private void refreshDataGrid<T>(string keyword)
        {
            try
            {
                dgvDBData.DataSource = JsonConvert.DeserializeObject<List<object>>(new Sender().Receive("https://testerinho.com/vatrogasci/gettable.php?table=" + keyword));
                dgvDBData.KeyDown += dgvDBData_KeyDown;
                dgvDBData.CellDoubleClick += dgvDBData_CellClick<T>;
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
        void dgvDBData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int pos = dgvDBData.SelectedCells[0].RowIndex;
                string name = dgvDBData.Rows[pos].Cells["Ime"].Value.ToString() + " " + dgvDBData.Rows[pos].Cells["Prezime"].Value.ToString();
                if (MessageBox.Show("Jeste li sigurni da želite obrisati redak " + name, "Potvrda", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //zovi php TODO
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
            dgvDBData.CellDoubleClick -= dgvDBData_CellClick<T>;
            DataGridViewRow row = dgvDBData.Rows[e.RowIndex];
            
            //parse type Vatrogasac
            if (typeof(T) == typeof(Vatrogasac))
            {
                new PodaciClana(row).ShowDialog();
                this.RefreshPanel<Vatrogasac>("Članovi");
            }
            
        }

        /// <summary>
        /// Otvara se forma s narudžbama kada klikne na gumb Ispis narudžbi u formi za opreme.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IspisNarudzbi_Click(object sender, EventArgs e)
        {
            NarudzbeForma frmNarudzbe = new NarudzbeForma();
            frmNarudzbe.Show();
        }

        /// <summary>
        /// Otvara formu s dobavljačima kada klikne na gumb Dobavljači u formi s narudžbama.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dobavljac_Click(object sender, EventArgs e)
        {
            DobavljaciForma frmDobavljaci = new DobavljaciForma();
            frmDobavljaci.Show();
        }

        /// <summary>
        /// Otvori prijavu na natjecanje kada klikne na gumb prijavi se u formi za natjecanja.
        /// Treba dodati da mora natjecanje biti odabrano prethodno.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Prijavi_ekipu_natjecanje_Click(object sender, EventArgs e)
        {
            PodaciPrijava frmPrijava = new PodaciPrijava();
            frmPrijava.Show();
        }

        /// <summary>
        /// Ovo je univerzalni gumbić Dodaj koji se prikazuje na svim formama. Budući da svaka forma
        /// otvara drukčiju formu, onda se parsa labela na vrhu i ovisno o njoj se otvaraju zadane forme.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (lblBase.Text == "Članovi") openForm(new PodaciClana());
            else if (lblBase.Text == "Intervencije") openForm(new PodaciIntervencije());
            else if (lblBase.Text == "Oprema") openForm(new PodaciOpreme());
            else if (lblBase.Text == "Natjecanja") openForm(new PodaciNatjecanje());
            else if (lblBase.Text == "Dobavljači") openForm(new PodaciDobavljaca());
        }

        /// <summary>
        /// Metoda koja otvara formu. Zasad ima samo frm.Show(), ali je odvojena zbog mogućih potreba
        /// da se ne može preći na parent formu dok je ova TopLevel forma otvorena.
        /// </summary>
        /// <param name="frm">Forma koja se otvara</param>
        private void openForm(Form frm)
        {
            frm.Show();
        }
    }
}
