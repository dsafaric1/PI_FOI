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

namespace VatrogasnoDrustvo.InputForms
{
    /// <summary>
    /// Forma za prijavu na natjecanje (unos)
    /// </summary>
    public partial class PodaciPrijava : Form
    {
        List<Dictionary<string, string>> persons;
        Natjecanje odabrano;

        public PodaciPrijava(Natjecanje natjecanje)
        {
            InitializeComponent();
            odabrano = natjecanje;
            comboBox1.DataSource = Enum.GetValues(typeof(KategorijaEkipe)).Cast<KategorijaEkipe>().ToList();
            fillCheckbox();
        }

        private void fillCheckbox()
        {
            persons = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>
                        (new Sender().Receive("http://46.101.122.250/gettable.php?table=Competitors&natjecanje=" + odabrano.ID.ToString()));

            //provjeri da li je trenutni vatrogasac već zapisan
            bool zapisan = true;
            foreach (Dictionary<string, string> p in persons)
            {
                if (p["OIB"] == GlavnaForma.TrenutniVatrogasac.OIB)
                {
                    zapisan = false;
                    continue;
                }
                chckClanoviEkipe.Items.Add(p["Osoba"]);
            }

            if (zapisan)
            {
                MessageBox.Show("Već ste prijavljeni na ovom natjecanju!");
                this.Close();
            }
        }

        private void btnPrijavi_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text == "") 
            {
                MessageBox.Show("Naziv ekipe mora biti unesen!");
                return;
            }
            //stvori ekipu
            Ekipa nova = new Ekipa(txtNaziv.Text, (KategorijaEkipe)Enum.Parse(typeof(KategorijaEkipe), comboBox1.Text), GlavnaForma.TrenutniVatrogasac);

            //puni ekipu članovima
            foreach (string item in chckClanoviEkipe.CheckedItems)
            {
                foreach (var person in persons)
                {
                    if (item == person["Osoba"])
                    {
                        nova.AddClan(new Vatrogasac { OIB = person["OIB"] });
                    }
                }
            }

            try
            {
                //MessageBox.Show(new Sender().Send(nova, "http://46.101.122.250/prijaviNaNatjecanje.php", odabrano));
                var response = JsonConvert.DeserializeObject<Dictionary<string, object>>
                    (new Sender().Send(nova, "http://46.101.122.250/prijaviNaNatjecanje.php", odabrano));

                if (bool.Parse(response["passed"].ToString()))
                {
                    MessageBox.Show("Prijavljeni ste na natjecanje!");
                }
                else
                {
                    MessageBox.Show(response["text"].ToString());
                }
                this.Close();
            }
            catch (Exception xe)
            {
                MessageBox.Show("Pogreška kod kontaktiranja servera za prijavu! " + xe.ToString());
            }
        }
    }
}
