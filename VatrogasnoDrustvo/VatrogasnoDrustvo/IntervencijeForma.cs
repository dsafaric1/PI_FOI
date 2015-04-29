using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VatrogasnoDrustvo
{
    public partial class IntervencijeForma : VatrogasnoDrustvo.BaseDataGridForma
    {
        public IntervencijeForma()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            PodaciIntervencije frmPodaciIntervencije = new PodaciIntervencije();
            frmPodaciIntervencije.Show();
        }
    }
}
