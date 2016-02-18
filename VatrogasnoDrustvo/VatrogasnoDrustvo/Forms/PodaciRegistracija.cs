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

namespace VatrogasnoDrustvo.Forms
{
    public partial class PodaciRegistracija : Form
    {
        List<Dictionary<string, string>> persons;

        public PodaciRegistracija()
        {
            InitializeComponent();
            fillSelect();
        }

        private void fillSelect()
        {
            //dohvati osobe koje nisu korisnici
            persons = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>
                    (new Sender().Receive("http://46.101.122.250/gettable.php?table=NonUsers"));

            //učitaj ime + prezime osobe u padajuću listu
            List<string> vals = new List<string>();
            persons.ForEach(k => vals.Add(k["Osoba"]));
            this.cmbClanovi.DataSource = vals;

            //ako su svi korisnici, nema smisla otvarati formu
            if (persons.Count == 0)
            {
                MessageBox.Show("Svi članovi su registrirani!");
                this.Close();
            }
        }

        private void btnRegistriraj_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            bool usernameCheck = new Regex(".{6,}").Match(username).Success;
            bool passwordCheck = new Regex(".{5,}").Match(password).Success;

            if (usernameCheck)
            {
                if (passwordCheck)
                {
                    string oib = null;
                    //pronađi oib od odabranog korisnika
                    foreach(var item in persons) {
                        if(item["Osoba"].ToString() == cmbClanovi.Text) {
                            oib = item["OIB"].ToString();
                        } 
                    }

                    //sve u dict za json
                    Dictionary<string, string> dict = new Dictionary<string, string> 
                    { 
                        {"username", username}, {"password", password}, { "user", oib }
                    };

                    //šalji tko se registira
                    var response = JsonConvert.DeserializeObject<Dictionary<string, object>>
                        (new Sender().Send(dict, "http://46.101.122.250/addUser.php"));

                    //obradi odgovor
                    if (bool.Parse(response["passed"].ToString()))
                    {
                        MessageBox.Show("Član je uspješno registriran!");
                    }
                    else
                    {
                        MessageBox.Show(response["text"].ToString());
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lozinka mora imati najmanje 5 znakova!");
                }
            }
            else
            {
                MessageBox.Show("Korisničko ime mora imati najmanje 6 znakova!");
            }
        }
    }
}
