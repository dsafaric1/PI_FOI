using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VatrogasnoDrustvo
{
    public partial class OpremaForma : VatrogasnoDrustvo.BaseDataGridForma
    {
        public OpremaForma()
        {
            InitializeComponent();
        }

        private void btnOpremaNarudzba_Click(object sender, EventArgs e)
        {
            NarudzbeForma frmNarudzba = new NarudzbeForma();
            frmNarudzba.Show();
            frmNarudzba.TopMost = true;
            frmNarudzba.TopLevel = true;
        }
    }
}
