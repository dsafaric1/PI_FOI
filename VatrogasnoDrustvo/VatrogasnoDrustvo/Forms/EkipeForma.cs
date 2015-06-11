using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VatrogasnoDrustvo.Bridge;
using VatrogasnoDrustvo.Core;

namespace VatrogasnoDrustvo.Forms
{
    public partial class EkipeForma : Form
    {
        Natjecanje kliknuto;
        DataGridView dgv;
        bool admin;

        /// <summary>
        /// Konstruktor za povlačenje podataka o ekipi
        /// </summary>
        /// <param name="natjecanje">Natjecanje za kojeg se zanima</param>
        /// <param name="admin">Da li je korisnik admin</param>
        public EkipeForma(Natjecanje natjecanje, bool admin)
        {
            InitializeComponent();
            kliknuto = natjecanje;
            (tablePanel1.Controls.Find("btnDodaj", true).FirstOrDefault() as Button).Visible = false;
            (tablePanel1.Controls.Find("lblBase", true).FirstOrDefault() as Label).Text = "Ekipe";
            dgv = tablePanel1.Controls.Find("dgvDBData", true).FirstOrDefault() as DataGridView;
            this.admin = admin;
            setCustomPanelEvent();
        }

        /// <summary>
        /// Za ekipu je potreban posebni tretman jer ovisi o natjecanju, pa
        /// ne može izvršiti iniciranje kroz RefreshPanel
        /// </summary>
        private void setCustomPanelEvent()
        {
            try
            {
                //za read
                dgv.DataSource = JsonConvert.DeserializeObject<List<object>>
                    (new Sender().Receive("https://testerinho.com/vatrogasci/gettable.php?table=Ekipe&natjecanje=" + kliknuto.ID));
                dgv.CellDoubleClick -= dgv_CellDoubleClick;
                dgv.CellDoubleClick += dgv_CellDoubleClick;
            }
            catch (Exception e)
            {
                MessageBox.Show("Pogreška u dohvaćanju ekipa! " + e.ToString());
            }
        }

        /// <summary>
        /// Handler za dupli klik na ćeliju
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new PodaciEkipe(dgv.Rows[e.RowIndex], admin).ShowDialog();
            setCustomPanelEvent();
        }
    }
}
