﻿using System;
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
    public partial class frmIntervencije : Form
    {
        public frmIntervencije()
        {
            InitializeComponent();
        }

        private void btnIntervencijeDodaj_Click(object sender, EventArgs e)
        {
            frmPodaciIntervencije unos_intervencije = new frmPodaciIntervencije();
            unos_intervencije.Show();
        }
    }
}
