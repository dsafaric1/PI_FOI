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

namespace VatrogasnoDrustvo.Forms
{
    public partial class PodaciEkipe : Form
    {
        Ekipa trenutna;

        /// <summary>
        /// Konstruktor za dohvat podataka o ekipi
        /// </summary>
        /// <param name="row"></param>
        public PodaciEkipe(DataGridViewRow row, bool admin)
        {
            InitializeComponent();

            //po potrebni sakrij botun
            if (!admin)
            { 
                btnSalji.Visible = false;
                txtNaziv.ReadOnly = true;
                numOcjena.ReadOnly = true;
                numRezultat.ReadOnly = true;
            }

            //stvori objekt ekipe i pohrani vrijednosti u textboxove
            trenutna = new Ekipa(row);
            txtNaziv.Text = trenutna.Naziv;
            numRezultat.Value = trenutna.Rezultat;
            numOcjena.Value = trenutna.Ocjena;
            dataGridView1.DataSource = trenutna.Clanovi;

            //sakrij neinteresantne stupce
            for (int i = 3; i < dataGridView1.Columns.Count; i++)
                dataGridView1.Columns[i].Visible = false;
        }

        private void btnSalji_Click(object sender, EventArgs e)
        {
            decimal ocjena = numOcjena.Value;
            decimal rezultat = numRezultat.Value;
            string naziv = txtNaziv.Text;
            Dictionary<string, object> json = new Dictionary<string,object> {
                { "ocjena", ocjena },
                { "rezultat", rezultat },
                { "naziv", naziv }
            };

            //create
            try
            {
                //MessageBox.Show(new Sender().Send(json, "https://testerinho.com/vatrogasci/ocijeniEkipu.php", trenutna));
                var response = JsonConvert.DeserializeObject<Dictionary<string, object>>
                    (new Sender().Send(json, "https://testerinho.com/vatrogasci/ocijeniEkipu.php", trenutna));

                if (bool.Parse(response["passed"].ToString()))
                {
                    MessageBox.Show("Rezultati su unešeni!");
                }
                else
                {
                    MessageBox.Show(response["text"].ToString());
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pogreška u kontaktiranju servera!" + Environment.NewLine + ex.ToString());
            }
        }
    }
}
