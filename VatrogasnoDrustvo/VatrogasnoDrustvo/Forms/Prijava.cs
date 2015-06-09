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

namespace VatrogasnoDrustvo
{
    /// <summary>
    /// Forma za prijavu korisnika u sustav
    /// </summary>
    public partial class frmPrijava : Form
    {

        public frmPrijava()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda koja obrađuje OnClick event na gumbić Prijavi se. Prilikom klika, 
        /// kontaktira se server i ovisno o odgovoru koji vrati otvoriti će se glavna
        /// forma aplikacije.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            //username i password unesen
            if (txtKorIme.Text.Trim().Length != 0 && txtLozinka.Text.Trim().Length != 0)
            {
                string username = txtKorIme.Text;
                string password = txtLozinka.Text;

                //parametre u dict zbog json formata
                Dictionary<string, string> userInfo = new Dictionary<string, string> 
                { 
                    {"username", username}, 
                    {"password", password} 
                }; 

                //šalji json i parsaj odgovor
                var response = JsonConvert.DeserializeObject<Dictionary<string,object>>(new Sender().Send(userInfo, "https://testerinho.com/vatrogasci/login.php"));
                if (bool.Parse(response["valid"].ToString()))
                {
                    this.Visible = false;
                    Vatrogasac trenutni = JsonConvert.DeserializeObject<Vatrogasac>(response["vatrogasac"].ToString());
                    bool admin = bool.Parse(response["admin"].ToString());
                    GlavnaForma frm = new GlavnaForma(trenutni, admin);
                    frm.Show();
                }
                else
                {
                    MessageBox.Show(response["text"].ToString());
                }
            }
            //nije unesen
            else
            {
                MessageBox.Show("Morate unijeti korisničko ime i lozinku!");
            }
        }
    }
}
