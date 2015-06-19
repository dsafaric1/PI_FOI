using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using VatrogasnoDrustvo.Bridge;

namespace VatrogasnoDrustvo.Forms
{
    public partial class GraphPanel : UserControl
    {
        public GraphPanel()
        {
            InitializeComponent();
        }

        public void RefreshData(string keyword) 
        {
            try
            {
                //za read
                MessageBox.Show(new Sender().Receive("https://testerinho.com/vatrogasci/gettable.php?table=" + keyword));
                dataGridView1.DataSource = JsonConvert.DeserializeObject<List<object>>
                    (new Sender().Receive("https://testerinho.com/vatrogasci/gettable.php?table=" + keyword));
            }
            catch (Exception e)
            {
                MessageBox.Show("Pogreška u dohvaćanju podataka! " + Environment.NewLine + e);
            }
        }

        private void lblOcjena_Click(object sender, EventArgs e)
        {
            RefreshData("ProsječnaOcjena");
        }

        private void lblRezultati_Click(object sender, EventArgs e)
        {
            RefreshData("Rezultati");
        }

        private void lblIntervencije_Click(object sender, EventArgs e)
        {
            RefreshData("MjesecIntervencija");
        }

        private void lblPotrosnja_Click(object sender, EventArgs e)
        {
            RefreshData("MjesecPotrošnje");
        }
    }
}
