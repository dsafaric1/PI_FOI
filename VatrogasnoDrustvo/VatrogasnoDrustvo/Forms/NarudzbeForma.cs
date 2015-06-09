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
    /// Forma za tablični prikaz narudžbi van glavne forme.
    /// Skočni prozor prilikom klika na gumb Ispis narudžbi u panelu Oprema.
    /// </summary>
    public partial class NarudzbeForma : Form
    {
        public NarudzbeForma()
        {
            InitializeComponent();
            pnlNarudzbe.RefreshPanel<Narudzba>("Narudžbe"); //ovo je potrebno da se user kontrola TablePanel prilagodi za narudžbe (labela, gumbići, itd.)
        }
    }
}
