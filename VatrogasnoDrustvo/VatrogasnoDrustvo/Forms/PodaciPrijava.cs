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

namespace VatrogasnoDrustvo.InputForms
{
    /// <summary>
    /// Forma za prijavu na natjecanje (unos)
    /// </summary>
    public partial class PodaciPrijava : Form
    {
        public PodaciPrijava()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(KategorijaEkipe)).Cast<KategorijaEkipe>().ToList();
            fillCheckbox();
        }

        private void fillCheckbox()
        {
            //TODO povlačenje s phpom i punjenje
            //chckClanoviEkipe.Items.Add();
        }
    }
}
