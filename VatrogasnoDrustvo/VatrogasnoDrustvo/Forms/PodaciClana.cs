using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

            //puni textboxove
            this.txtPodaciClanaIme.Text = mirko.Ime;
            this.txtPodaciClanaPrezime.Text = mirko.Prezime;
            this.txtPodaciClanaAdresa.Text = mirko.Adresa;
            this.dtpPodaciClanaUclanjenje.Value = DateTime.Parse(mirko.DatumUclanjenja);
            this.dtpPodaciClanaRodenje.Value = DateTime.Parse(mirko.DatumRodenja);
            this.cmbPodaciClanaDuznost.SelectedIndex = this.cmbPodaciClanaDuznost.FindString(mirko.Duznost.ToString());
            this.cmbPodaciClanaVrsta.SelectedIndex = this.cmbPodaciClanaVrsta.FindString(mirko.VrstaClana.ToString());
            this.cmbPodaciCLanaZvanje.SelectedIndex = this.cmbPodaciCLanaZvanje.FindString(mirko.Zvanje.ToString());
        }

        private void loadSelect() 
        {
            cmbPodaciClanaDuznost.DataSource = Enum.GetValues(typeof(Duznost)).Cast<Duznost>().ToList();
            cmbPodaciClanaVrsta.DataSource = Enum.GetValues(typeof(Clan)).Cast<Clan>().ToList();
            cmbPodaciCLanaZvanje.DataSource = Enum.GetValues(typeof(Zvanje)).Cast<Zvanje>().ToList();
        }

        private void btnPodaciClanaSpremi_Click(object sender, EventArgs e)
        {
            if (mirko != null)
            {
                this.TopMost = false;
                mirko.Ime = txtPodaciClanaIme.Text;
                mirko.Prezime = txtPodaciClanaPrezime.Text;
                mirko.VrstaClana = (Clan) Enum.Parse(typeof(Clan), cmbPodaciClanaVrsta.Text);
                mirko.Zvanje = (Zvanje) Enum.Parse(typeof(Zvanje), cmbPodaciCLanaZvanje.Text);
                mirko.Duznost = (Duznost) Enum.Parse(typeof(Duznost), cmbPodaciClanaDuznost.Text);
                mirko.Adresa = txtPodaciClanaAdresa.Text;
                mirko.DatumRodenja = dtpPodaciClanaRodenje.Value.ToString("yyyy-MM-dd HH:mm:ss");
                mirko.DatumUclanjenja = dtpPodaciClanaUclanjenje.Value.ToString("yyyy-MM-dd HH:mm:ss");

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
                        MessageBox.Show("Pogreška pri ažuriranju retka!" + Environment.NewLine + response["text"].ToString());
                    }                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Pogreška u kontaktiranju servera!" + Environment.NewLine + ex.ToString());
                }
            }
            else
            {
                //CREATE ČLAN
            }

            this.Close();
        }
    }
}
