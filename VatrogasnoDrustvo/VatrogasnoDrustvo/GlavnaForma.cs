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
    public partial class frmGlavnaForma : Form
    {
        public frmGlavnaForma()
        {
            InitializeComponent();
        }

        private void lblPrijavljenIme_Click(object sender, EventArgs e)
        {

        }

        private void tlstrpGlavnaForma_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tlstrplblClanovi_Click(object sender, EventArgs e)
        {
            frmClanovi clanovi = new frmClanovi();
            clanovi.Show();
        }
    }
}
