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
    /// <summary>
    /// Forma za unos/izmjenu dobavljača
    /// </summary>
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
            //ako je sve uneseno
            if (txtNazivDob.Text != "" && txtEmail.Text != "")
            {
                //ako je email dobrog formata
                if (!new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Match(txtEmail.Text).Success)
                {
                    MessageBox.Show("Email nije dobrog formata!");
                    return;
                }
                //adresa veliko slovo
                if (!new Regex(@"[A-Z]").Match(txtAdresa.Text).Success)
                {
                    MessageBox.Show("Adresa mora započeti velikim slovom!");
                    return;
                }
                //kontakt
                if (txtKontakt.Text != "" && !new Regex(@"^00\d{3,}$").Match(txtKontakt.Text).Success)
                {
                    MessageBox.Show("Kontakt broj nije pravilnog formata (format: 0038598983423, min 3 broja)");
                    return;
                }
                if (tvrtka != null)
                {
                    //update
                    updateDobavljac();
                }
                else
                {
                    //create
                    createDobavljac();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Sve vrijednosti osim kontakt broja moraju biti unesene!");
            }
        }

        /// <summary>
        /// Metoda za update dobavljača
        /// </summary>
        private void updateDobavljac()
        {
            //dohvat podataka
            tvrtka = getData(tvrtka);
            
            try
            {
                //MessageBox.Show(new Sender().Send(tvrtka, "https://testerinho.com/vatrogasci/updateDobavljac.php"));
                var response = JsonConvert.DeserializeObject<Dictionary<string, object>>(new Sender().Send(tvrtka, "https://testerinho.com/vatrogasci/updateDobavljac.php"));
                if (bool.Parse(response["passed"].ToString()))
                {
                    MessageBox.Show("Dobavljač je ažuriran!");
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
        /// Punjenje objekta sa podacima forme
        /// </summary>
        /// <param name="tvrtka">Trenutni dobavljač</param>
        /// <returns>Dobavljač sa ažuriranim podacima</returns>
        private Dobavljac getData(Dobavljac tvrtka = null)
        {
            if (tvrtka == null) tvrtka = new Dobavljac();
            tvrtka.Naziv = txtNazivDob.Text;
            tvrtka.Kontakt = txtKontakt.Text;
            tvrtka.Adresa = txtAdresa.Text;
            tvrtka.Email = txtEmail.Text;
            return tvrtka;
        }

        /// <summary>
        /// Metoda za kreiranje dobavljača (poziv POST)
        /// </summary>
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
