using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VatrogasnoDrustvo.Forme;

namespace VatrogasnoDrustvo
{
    /**
     * Forma za prijavu korisnika u sustav.
     */
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
        }

        /**
         * Metoda koja obrađuje OnClick event na gumbić Prijavi se. Zasad se otvara
         * samo glavna forma radi testiranja, al treba dodati logiku za obradu status koji
         * će vratiti poslužitelj
         */
        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            GlavnaForma frmGlavna = new GlavnaForma();
            frmGlavna.Show();
        }
    }
}
