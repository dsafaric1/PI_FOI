using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VatrogasnoDrustvo
{
    public partial class NarudzbeForma : VatrogasnoDrustvo.BaseForme.BaseListDataForma
    {
        public NarudzbeForma()
        {
            InitializeComponent();
        }

        private void btnDobavljaci_Click(object sender, EventArgs e)
        {
            DobavljaciForma frmDobavljaci = new DobavljaciForma();
            frmDobavljaci.TopLevel = true;
            frmDobavljaci.TopMost = true;
        }
    }
}
