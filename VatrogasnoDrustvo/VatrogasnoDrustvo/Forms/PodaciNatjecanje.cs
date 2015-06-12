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
using VatrogasnoDrustvo.Forme;
using VatrogasnoDrustvo.Forms;

namespace VatrogasnoDrustvo.InputForms
{
    /// <summary>
    /// Forma za unos novog natjecanja.
    /// </summary>
    public partial class PodaciNatjecanje : Form
    {
        private Natjecanje natjecanje;
        private bool admin;

        public PodaciNatjecanje()
        {
            InitializeComponent();
            btnEkipe.Visible = false;
            loadSelect();
            btnSalji.Text = "Kreiraj natjecanje";
        }

        public PodaciNatjecanje(DataGridViewRow row, bool admin)
        {
            InitializeComponent();
            loadSelect();

            this.admin = admin;
            natjecanje = new Natjecanje(row);

            //puni textboxove sa podacima
            txtMjesto.Text = natjecanje.Mjesto;
            txtNaziv.Text = natjecanje.Naziv;
            dtpVrijeme.Value = natjecanje.VrijemeOdrzavanja;
            numKotizacija.Value = natjecanje.Kotizacija;
            cmbTip.SelectedIndex = cmbTip.FindString(natjecanje.Tip.ToString());
             btnSalji.Text = "Ažuriraj natjecanje";
        }

        /// <summary>
        /// Puni dropdown sa svim vrijednostima pobrojenja tipova
        /// </summary>
        private void loadSelect()
        {
            cmbTip.DataSource = Enum.GetValues(typeof(TipNatjecanja)).Cast<TipNatjecanja>().ToList();
        }

        /// <summary>
        /// Kad se stisne šalji gumbić
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalji_Click(object sender, EventArgs e)
        {
            //ako su ispunjena sva polja
            if (txtMjesto.Text != "" && txtNaziv.Text != "")
            {
                //natjecanje povučeno iz retka
                if (natjecanje != null)
                {
                    updateNatjecanje();
                }
                else
                {
                    createNatjecanje();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Nisu ispunjena sva polja!");
            }
        }

        /// <summary>
        /// Povuci podatke iz inputa i kreiraj objekt
        /// </summary>
        /// <returns>Objekt iz textboxva tipa Natjecanje</returns>
        private Natjecanje getData(Natjecanje natjecanje)
        {
            if (natjecanje == null) natjecanje = new Natjecanje();
            natjecanje.Naziv = txtNaziv.Text;
            natjecanje.Mjesto = txtMjesto.Text;
            natjecanje.Tip = (TipNatjecanja)Enum.Parse(typeof(TipNatjecanja), cmbTip.Text);
            natjecanje.Kotizacija = numKotizacija.Value;
            natjecanje.VrijemeOdrzavanja = dtpVrijeme.Value;
            return natjecanje;
        }

        /// <summary>
        /// Metoda za kreiranje natjecanja
        /// </summary>
        private void createNatjecanje()
        {
            natjecanje = getData(natjecanje);
            try
            {
                var response = JsonConvert.DeserializeObject<Dictionary<string, object>>
                    (new Sender().Send(natjecanje, "https://testerinho.com/vatrogasci/insertNatjecanje.php", GlavnaForma.TrenutniVatrogasac));

                if (bool.Parse(response["passed"].ToString()))
                {
                    MessageBox.Show("Uneseno je novo natjecanje!");
                }
                else
                {
                    MessageBox.Show(response["text"].ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Pogreška u kontaktiranju servera " + e.ToString());
            }
        }

        /// <summary>
        /// Metoda za update natjecanja
        /// </summary>
        private void updateNatjecanje()
        {
            natjecanje = getData(natjecanje);
            try
            {
                //MessageBox.Show(new Sender().Send(natjecanje, "https://testerinho.com/vatrogasci/updateNatjecanje.php"));
                var response = JsonConvert.DeserializeObject<Dictionary<string, object>>
                    (new Sender().Send(natjecanje, "https://testerinho.com/vatrogasci/updateNatjecanje.php"));

                if (bool.Parse(response["passed"].ToString()))
                {
                    MessageBox.Show("Natjecanje je ažurirano!");
                }
                else
                {
                    MessageBox.Show(response["text"].ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Pogreška u kontaktiranju servera " + e.ToString());
            }
        }

        private void btnEkipe_Click(object sender, EventArgs e)
        {
            new EkipeForma(natjecanje, admin).ShowDialog();
        }
    }
}
