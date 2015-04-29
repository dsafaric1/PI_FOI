using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VatrogasnoDrustvo
{
    public partial class ClanoviForma : VatrogasnoDrustvo.BaseDataGridForma
    {
        public ClanoviForma()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            PodaciClana frmPodaciClana = new PodaciClana();
            frmPodaciClana.Show();
        }
    }
}
