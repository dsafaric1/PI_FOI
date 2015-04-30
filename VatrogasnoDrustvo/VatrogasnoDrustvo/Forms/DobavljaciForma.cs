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
    public partial class DobavljaciForma : Form
    {
        public DobavljaciForma()
        {
            InitializeComponent();
            pnlDobavljaci.refresh("Dobavljači");
        }
    }
}
