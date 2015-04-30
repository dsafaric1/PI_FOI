using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VatrogasnoDrustvo.Forme
{
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
            tlstrplblPocetna_Click(null, null);
        }

        private void tlstrplblPocetna_Click(object sender, EventArgs e)
        {
            pnlGlavna.BringToFront();
        }

        private void tlstrplblIntervencije_Click(object sender, EventArgs e)
        {
            exchange("Intervencije");   
        }

        private void tlstrplblClanovi_Click(object sender, EventArgs e)
        {
            exchange("Članovi");
        }

        private void tlstrplblOprema_Click(object sender, EventArgs e)
        {
            exchange("Oprema");
        }

        private void exchange(string keyword)
        {
            pnlTable.BringToFront();
            pnlTable.refresh(keyword);
            pnlTable.Refresh();
        }

        private void tlstrplblNatjecanja_Click(object sender, EventArgs e)
        {
            exchange("Natjecanja");
        }
    }
}
