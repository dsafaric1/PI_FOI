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
    public partial class BaseToolStripForma : Form
    {
        public BaseToolStripForma()
        {
            InitializeComponent();
        }
        protected void lblPrijavljenIme_Click(object sender, EventArgs e)
        {

        }

        private void tlstrplblPocetna_Click(object sender, System.EventArgs e)
        {
            GlavnaForma frmGlavna = new GlavnaForma();
            frmGlavna.Show();
            this.FindForm().Close();
        }

        protected virtual void tlstrplblClanovi_Click(object sender, EventArgs e)
        {
            ClanoviForma frmClanovi = new ClanoviForma();
            frmClanovi.Show();
            this.FindForm().Close();
        }

        protected void tlstrplblIntervencije_Click(object sender, EventArgs e)
        {
            IntervencijeForma frmIntervencija = new IntervencijeForma();
            openForm(frmIntervencija);
        }

        protected void tlstrplblOprema_Click(object sender, EventArgs e)
        {
            OpremaForma frmOprema = new OpremaForma();
            openForm(frmOprema);
        }

        protected void tlstrplblNatjecanja_Click(object sender, EventArgs e)
        {
            NatjecanjaForma frmNatjecanja = new NatjecanjaForma();
            openForm(frmNatjecanja);
        }

        private void openForm(Form formToOpen)
        {
            formToOpen.Show();
            this.FindForm().Close();
        }

    }
}
