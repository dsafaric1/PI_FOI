using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VatrogasnoDrustvo.Bridge;
using VatrogasnoDrustvo.Core;

namespace VatrogasnoDrustvo.Forme
{
    /// <summary>
    /// Forma za tablični prikaz narudžbi van glavne forme.
    /// Skočni prozor prilikom klika na gumb Ispis narudžbi u panelu Oprema.
    /// </summary>
    public partial class NarudzbeForma : Form
    {
        public NarudzbeForma(bool admin)
        {
            InitializeComponent();
            pnlNarudzbe.RefreshPanel<Narudzba>("Narudžbe", admin); //ovo je potrebno da se user kontrola TablePanel prilagodi za narudžbe (labela, gumbići, itd.)
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            DataGridView dgv = pnlNarudzbe.Controls.Find("dgvDBData", true).FirstOrDefault() as DataGridView;
            Narudzba selektirana = new Narudzba(dgv.Rows[dgv.CurrentCell.RowIndex]);

            if (new DocumentGenerator().GenerateDocument(selektirana))
            {
                Process.Start("order_VD.pdf");
            }
            else
            {
                MessageBox.Show("Ne mogu otvoriti datoteku, jeste li ju zatvorili?");
            }
        }
    }
}
