using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VatrogasnoDrustvo.Core;

namespace VatrogasnoDrustvo.Forme
{
    /// <summary>
    /// Skočni prozor koji otvara tablični prikaz dobavljača.
    /// Prozor skoči pritiskom na gumb Dobavljači u formi Narudžbe.
    /// </summary>
    public partial class DobavljaciForma : Form
    {
        public DobavljaciForma()
        {
            InitializeComponent();
            pnlDobavljaci.RefreshPanel<Dobavljac>("Dobavljači"); //potrebno da bi se pravilno inicirala TablePanel kontrola (labele, gumbići i sl.)
        }
    }
}
