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
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.Net.Mail;
namespace VatrogasnoDrustvo.InputForms
{
    /**
     * Forma za unos novog dobavljača.
     */
    public partial class PodaciDobavljaca : Form
    {
        Dobavljac tvrtka;

        public PodaciDobavljaca()
        {
            InitializeComponent();
        }

        public PodaciDobavljaca(DataGridViewRow row)
        {
            InitializeComponent();

            tvrtka = new Dobavljac(row);

            this.txtNazivDob.Text = tvrtka.Naziv;
            this.txtKontakt.Text = tvrtka.Kontakt;
            this.txtAdresa.Text = tvrtka.Adresa;
            this.txtEmail.Text = tvrtka.Email;
        }

        private void btnSalji_Click(object sender, EventArgs e)
        {
            if (txtNazivDob.Text != "" && txtKontakt.Text != "" && txtKontakt.Text != "" && txtEmail.Text != "")
            {
                if (new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Match(txtEmail.Text).Success)
                {
                    createDobavljac();

                    this.Close();
                }

                else
                {
                    MessageBox.Show("E-mail adresa nije ispravna");
                }

            }
            else
            {
                MessageBox.Show("Sve vrijednosti moraju biti unesene!");
            }
        }

        private Dobavljac getData(Dobavljac tvrtka = null)
        {
            if (tvrtka == null) tvrtka = new Dobavljac();
            tvrtka.Naziv = txtNazivDob.Text;
            tvrtka.Kontakt = txtKontakt.Text;
            tvrtka.Adresa = txtAdresa.Text;
            tvrtka.Email = txtEmail.Text;
            return tvrtka;
        }

        private void createDobavljac()
        {
            tvrtka = getData();

            try
            {
                var response = JsonConvert.DeserializeObject<Dictionary<string, object>>(new Sender().Send(tvrtka, "https://testerinho.com/vatrogasci/insertDobavljac.php"));
                if (bool.Parse(response["passed"].ToString()))
                {
                    MessageBox.Show("Novi dobavljač je uspješno unesen!");
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


    }
}
