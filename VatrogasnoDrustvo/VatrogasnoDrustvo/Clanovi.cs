using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VatrogasnoDrustvo
{
    public partial class frmClanovi : Form
    {
        public frmClanovi()
        {
            InitializeComponent();
        }

        private void lblClanoviShow_Click(object sender, EventArgs e)
        {

        }

        private void tlstrplblClanoviIntervencije_Click(object sender, EventArgs e)
        {

        }

        private void btnClanoviDodaj_Click(object sender, EventArgs e)
        {
            frmPodaciClana novi_clan = new frmPodaciClana();
            novi_clan.Show();
        }
    }
}
