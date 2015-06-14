using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VatrogasnoDrustvo.Bridge;
using VatrogasnoDrustvo.Core;

namespace VatrogasnoDrustvo
{
    /// <summary>
    /// Forma za unos novog člana društva. Ne misli se na registraciju.
    /// </summary>
    public partial class PodaciClana : Form
    {
        Vatrogasac mirko;

        public PodaciClana()
        {
            InitializeComponent();
            loadSelect();
        }

        public PodaciClana(DataGridViewRow row)
        {
            InitializeComponent();
            loadSelect();

            //parsaj vatrogasca
            mirko = new Vatrogasac(row);

            //gasi OIB
            this.txtOIB.ReadOnly = true;
            this.lblOIB.Visible = false;

            //puni textboxove
            this.txtOIB.Text = mirko.OIB;
            this.txtPodaciClanaIme.Text = mirko.Ime;
            this.txtPodaciClanaPrezime.Text = mirko.Prezime;
            this.txtPodaciClanaAdresa.Text = mirko.Adresa;
            this.dtpPodaciClanaUclanjenje.Value = DateTime.Parse(mirko.DatumUclanjenja);
            this.dtpPodaciClanaRodenje.Value = DateTime.Parse(mirko.DatumRodenja);
            this.cmbPodaciClanaDuznost.SelectedIndex = this.cmbPodaciClanaDuznost.FindString(mirko.Duznost.ToString());
            this.cmbPodaciClanaVrsta.SelectedIndex = this.cmbPodaciClanaVrsta.FindString(mirko.VrstaClana.ToString());
            this.cmbPodaciCLanaZvanje.SelectedIndex = this.cmbPodaciCLanaZvanje.FindString(mirko.Zvanje.ToString());
        }

        /// <summary>
        /// Metoda za punjenje combobox kontrola sa listom svih pobrojenja.
        /// Dodatno, postavljanje max datuma za datum rođenja
        /// </summary>
        private void loadSelect() 
        {
            cmbPodaciClanaDuznost.DataSource = Enum.GetValues(typeof(Duznost)).Cast<Duznost>().ToList();
            cmbPodaciClanaVrsta.DataSource = Enum.GetValues(typeof(Clan)).Cast<Clan>().ToList();
            cmbPodaciCLanaZvanje.DataSource = Enum.GetValues(typeof(Zvanje)).Cast<Zvanje>().ToList();
            dtpPodaciClanaRodenje.MaxDate = DateTime.Today.AddYears(-5);
            dtpPodaciClanaUclanjenje.MaxDate = DateTime.Today;
        }

        /// <summary>
        /// OnClick na gumb spremi u prozoru s formom podataka člana.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPodaciClanaSpremi_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            //ako je sve popunjeno
            if (txtPodaciClanaAdresa.Text != "" && txtPodaciClanaIme.Text != ""
                && txtPodaciClanaPrezime.Text != "" && txtOIB.Text != "")
            {
                //validacija
                //ako oib ima 11 brojeva
                if (!new Regex(@"\d{11}").Match(txtOIB.Text).Success)
                {
                    MessageBox.Show("OIB mora imati 11 brojeva.");
                    return;
                }
                //ime, prezime i adresa veliko slovo
                if (!new Regex(@"[A-Z]").Match(txtPodaciClanaIme.Text).Success || !new Regex(@"[A-Z]").Match(txtPodaciClanaPrezime.Text).Success
                    || !new Regex(@"[A-Z]").Match(txtPodaciClanaAdresa.Text).Success)
                {
                    MessageBox.Show("Ime, prezime i adresa moraju imati veliko početno slovo!");
                    return;
                }
                if (mirko != null)
                {
                    //update
                    updateVatro(mirko);
                }
                else
                {
                    //create
                    createVatro();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Sve vrijednosti moraju biti unesene!");
            }
            
        }

        private Vatrogasac getData(Vatrogasac mirko = null)
        {
            if(mirko == null) mirko = new Vatrogasac();
            mirko.OIB = txtOIB.Text;
            mirko.Ime = txtPodaciClanaIme.Text;
            mirko.Prezime = txtPodaciClanaPrezime.Text;
            mirko.VrstaClana = (Clan)Enum.Parse(typeof(Clan), cmbPodaciClanaVrsta.Text);
            mirko.Zvanje = (Zvanje)Enum.Parse(typeof(Zvanje), cmbPodaciCLanaZvanje.Text);
            mirko.Duznost = (Duznost)Enum.Parse(typeof(Duznost), cmbPodaciClanaDuznost.Text);
            mirko.Adresa = txtPodaciClanaAdresa.Text;
            mirko.DatumRodenja = dtpPodaciClanaRodenje.Value.ToString("yyyy-MM-dd HH:mm:ss");
            mirko.DatumUclanjenja = dtpPodaciClanaUclanjenje.Value.ToString("yyyy-MM-dd HH:mm:ss");
            return mirko;
        }

        /// <summary>
        /// Poziv php skripte za kreiranje novog člana.
        /// </summary>
        private void createVatro()
        {
            mirko = getData();

            //create
            try
            {
                var response = JsonConvert.DeserializeObject<Dictionary<string, object>>(new Sender().Send(mirko, "https://testerinho.com/vatrogasci/insertVatrogasac.php"));

                if (bool.Parse(response["passed"].ToString()))
                {
                    MessageBox.Show("Novi član je uspješno unesen!");
                }
                else
                {
                    MessageBox.Show(response["text"].ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Pogreška u kontaktiranju servera!" + Environment.NewLine + e.ToString());
            }
        }

        /// <summary>
        /// Poziv php skripte za ažuriranje člana.
        /// </summary>
        /// <param name="mirko">Podaci člana kojeg se ažurira</param>
        private void updateVatro(Vatrogasac mirko)
        {
            mirko = getData(mirko);

            //update
            try
            {
                var response = JsonConvert.DeserializeObject<Dictionary<string, object>>(new Sender().Send(mirko, "https://testerinho.com/vatrogasci/updateVatrogasac.php"));

                if (bool.Parse(response["passed"].ToString()))
                {
                    MessageBox.Show("Uspješno je ažuriran redak!");
                }
                else
                {
                    MessageBox.Show(response["text"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pogreška u kontaktiranju servera!" + Environment.NewLine + ex.ToString());
            }
        }
    }
}
