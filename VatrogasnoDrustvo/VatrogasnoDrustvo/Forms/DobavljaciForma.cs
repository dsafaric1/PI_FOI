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
    /**
     * Skočni prozor koji otvara tablični prikaz dobavljača.
     * Prozor skoči pritiskom na gumb Dobavljači u formi Narudžbe.
     */
    public partial class DobavljaciForma : Form
    {
        public DobavljaciForma()
        {
            InitializeComponent();
            pnlDobavljaci.refresh("Dobavljači"); //potrebno da bi se pravilno inicirala TablePanel kontrola (labele, gumbići i sl.)
        }
    }
}
