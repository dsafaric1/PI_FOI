using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using VatrogasnoDrustvo.Bridge;
using VatrogasnoDrustvo.Core;
using System.Text.RegularExpressions;
using VatrogasnoDrustvo.Forme;

namespace VatrogasnoDrustvo
{
    /// <summary>
    /// Forma za unos novog natjecanja.
    /// </summary>
    public partial class PodaciIntervencije : Form
    {
        Intervencija nova;
        List<Dictionary<string, string>> persons;
        

        public PodaciIntervencije()
        {
            InitializeComponent();
            loadSelect();
        }

        public PodaciIntervencije(DataGridViewRow row)
        {
            InitializeComponent();
            loadSelect();

            nova = new Intervencija(row);

            this.txtPodaciIntevencijeMjesto.Text = nova.Mjesto;
            this.txtPodaciIntevencijeAdresa.Text = nova.Adresa;
            this.dtpPocetnoVrijeme.Text = nova.PocetnoVrijeme;
            this.dtpZavrsnoVrijeme.Text = nova.ZavrsnoVrijeme;
            this.cmbPodaciIntevencijeVrsta.SelectedIndex = this.cmbPodaciIntevencijeVrsta.FindString(nova.Vrsta.ToString());
            this.txtPodaciIntevencijeUzrok.Text = nova.Uzrok;
            this.txtPodaciIntevencijeOpis.Text = nova.Opis;
            foreach (var item in nova.prisutniVatrogasci)
            {
                for(int i=0; i<chcklPodaciIntevencijeVatrogasci.Items.Count; i++)
                {
                    if (item.Ime + " " + item.Prezime == chcklPodaciIntevencijeVatrogasci.Items[i].ToString())
                    {
                        chcklPodaciIntevencijeVatrogasci.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void loadSelect()
        {
            cmbPodaciIntevencijeVrsta.DataSource = Enum.GetValues(typeof(VrstaIntervencije)).Cast<VrstaIntervencije>().ToList();

            persons = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>
                        (new Sender().Receive("https://testerinho.com/vatrogasci/gettable.php?table=Competitors"));

            foreach (Dictionary<string, string> p in persons)
            {
                chcklPodaciIntevencijeVatrogasci.Items.Add(p["Osoba"]);
            }
        }

        private void btnPodaciIntevencijeSpremi_Click(object sender, EventArgs e)
        {
            if (chcklPodaciIntevencijeVatrogasci.CheckedItems.Count != 0 && txtPodaciIntevencijeMjesto.Text != "" && txtPodaciIntevencijeAdresa.Text != "" && txtPodaciIntevencijeOpis.Text != "" && txtPodaciIntevencijeUzrok.Text != "" && dtpPocetnoVrijeme.Text != "" && dtpZavrsnoVrijeme.Text != "" && cmbPodaciIntevencijeVrsta.SelectedItem != null)
            {
                if (nova != null)
                {
                    updateIntervencija(nova);
                }
                else
                {
                    createIntervencija();
                }
                nova.prisutniVatrogasci = null;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sve vrijesnosti moraju biti unesene!");
            }
        }

        private Intervencija getData(Intervencija nova = null)
        {
            if (nova == null)
            {
                nova = new Intervencija();
                nova.Upisao = GlavnaForma.TrenutniVatrogasac;
            }
            nova.Mjesto = txtPodaciIntevencijeMjesto.Text;
            nova.Adresa = txtPodaciIntevencijeAdresa.Text;
            nova.Opis = txtPodaciIntevencijeOpis.Text;
            nova.Uzrok = txtPodaciIntevencijeUzrok.Text;
            nova.PocetnoVrijeme = dtpPocetnoVrijeme.Text;
            nova.ZavrsnoVrijeme = dtpZavrsnoVrijeme.Text;
            nova.Vrsta = (VrstaIntervencije)Enum.Parse(typeof(VrstaIntervencije), cmbPodaciIntevencijeVrsta.Text);
            nova.prisutniVatrogasci = new List<Vatrogasac>();
            foreach (var item in chcklPodaciIntevencijeVatrogasci.CheckedItems)
            {
                foreach (var p in persons)
                {
                    if(p["Osoba"] == item)
                        nova.AddPrisutniVatrogasac(new Vatrogasac { OIB = p["OIB"] });
                }  
            }
            
            return nova;
        }

        private void createIntervencija()
        {
            nova = getData();

            try
            {
                //MessageBox.Show(new Sender().Send(nova, "https://testerinho.com/vatrogasci/insertIntervencija.php", nova.Upisao));
                var response = JsonConvert.DeserializeObject<Dictionary<string, object>>
                    (new Sender().Send(nova, "https://testerinho.com/vatrogasci/insertIntervencija.php", nova.Upisao));

                if (bool.Parse(response["passed"].ToString()))
                {
                    MessageBox.Show("Nova intervencija je uspješno unesena!");
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

        private void updateIntervencija(Intervencija nova)
        {
            nova = getData(nova);
            
            try
            {
                //MessageBox.Show(new Sender().Send(nova, "https://testerinho.com/vatrogasci/updateIntervencija.php"));

                var response = JsonConvert.DeserializeObject<Dictionary<string, object>>(new Sender().Send(nova, "https://testerinho.com/vatrogasci/updateIntervencija.php"));

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
