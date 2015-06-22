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
using VatrogasnoDrustvo.Forms;

namespace VatrogasnoDrustvo.Forme
{
    /// <summary>
    /// Glavna forma koja se otvara nakon prijave. Ima na vrhu
    /// ToolStrip objekt s poveznicama za promjenu prikaza panela.
    /// </summary>
    public partial class GlavnaForma : Form
    {
        public static Vatrogasac TrenutniVatrogasac { get; set; }
        public bool Admin { get; set; }

        public GlavnaForma(Vatrogasac mirko, bool admin)
        {
            InitializeComponent();

            //prilagođavanje glavne forme za trenutnog korisnika
            TrenutniVatrogasac = mirko;
            Label vatroIme = pnlGlavna.Controls.Find("lblPrijavljenIme", true).FirstOrDefault() as Label;
            Label vatroZvanje = pnlGlavna.Controls.Find("lblZvanje", true).FirstOrDefault() as Label;
            vatroIme.Text = TrenutniVatrogasac.Ime + " " + TrenutniVatrogasac.Prezime;
            vatroZvanje.Text = TrenutniVatrogasac.Zvanje.ToString();

            //preuzmi status admina i sakrij Registraciju i Izvještaje, ako nije admin
            this.Admin = admin;
            if (!this.Admin)
            {
                tlstrpLabelRegistracija.Visible = false;
                tlstrplblIzvjestaji.Visible = false;
                toolStripSeparator3.Visible = false;
            }

            //Glavna forma nije zapravo glavna pa treba gasiti cijelu aplikaciju ručno
            this.FormClosed += GlavnaForma_FormClosed;
            //na F1 otvara pomoć u aplikaciji
            this.HelpRequested += GlavnaForma_HelpRequested;
            //Potrebno da se na početku prikaže panel s dobrodošlicom
            tlstrplblPocetna_Click(null, null); 
        }

        void GlavnaForma_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, @"Resources\vatrogasno_help.chm");
        }

        /// <summary>
        /// Handler za gašenje aplikacije prilikom gašenja glavne forme.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GlavnaForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Restart();
        }

        /// <summary>
        /// Metoda koja obrađuje OnClick na labelu početna u ToolStrip objektu.
        /// Dovoljno je panel s dobrodošlicom gurnuti napred do korisnika.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlstrplblPocetna_Click(object sender, EventArgs e)
        {
            pnlGlavna.BringToFront();
        }

        /// <summary>
        /// Metoda koja obrađuje OnClick na labelu intervencije u ToolStrip objektu.
        /// Metoda exchange objašnjena je niže.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlstrplblIntervencije_Click(object sender, EventArgs e)
        {
            exchange<Intervencija>("Intervencije");   
        }

        /// <summary>
        /// Metoda koja obrađuje OnClick na labelu članovi u ToolStrip objektu.
        /// Metoda exchange objašnjena je niže.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlstrplblClanovi_Click(object sender, EventArgs e)
        {
            exchange<Vatrogasac>("Članovi");
        }

        /// <summary>
        /// Metoda koja obrađuje OnClick na labelu oprema u ToolStrip objektu.
        /// Metoda exchange objašnjena je niže.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlstrplblOprema_Click(object sender, EventArgs e)
        {
            exchange<Oprema>("Oprema");
        }

        /// <summary>
        ///  Metoda koja TablePanel pomakne napred do korisnika, a nakon toga
        /// poziva internu metodu refresh (implementirana u klasi TablePanel) koja
        /// prima string parametar, a rezultira promjenom interne labele i gumbića te
        /// njihovih EventHandlera (u TablePanel kontroli). Kad je sve obavljeno poziva
        /// se metoda Refresh implementirana u klasi Control za osvježavanje kontrole.
        /// </summary>
        /// <param name="keyword">Naziv tablice</param>
        private void exchange<T>(string keyword)
        {
            pnlTable.RefreshPanel<T>(keyword, Admin);
            pnlTable.BringToFront();
        }

        /// <summary>
        /// Metoda koja obrađuje OnClick na labelu natjecanja u ToolStrip objektu.
        /// Metoda exchange objašnjena je iznad.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlstrplblNatjecanja_Click(object sender, EventArgs e)
        {
            exchange<Natjecanje>("Natjecanja");
        }

        /// <summary>
        /// Otvaranje forme za registraciju. Ako ne postoji korisnik za registriranje
        /// forma se ne otvara pa postaje disposana, zato se stavlja if is disposed da
        /// nebi došlo do iznimke.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlstrpLabelRegistracija_Click(object sender, EventArgs e)
        {
            PodaciRegistracija frmReg = new PodaciRegistracija();
            if(!frmReg.IsDisposed) frmReg.ShowDialog();
        }

        private void tlstrplblIzvjestaji_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            pnlStatistics.BringToFront();
        }

        /// <summary>
        /// Metoda za osvježavanje statističkih podataka u datagridview
        /// </summary>
        private void RefreshData(string keyword)
        {
            panel1.Visible = true;
            try
            {
                //za read
                //MessageBox.Show(new Sender().Receive("https://testerinho.com/vatrogasci/gettable.php?table=" + keyword));
                dgvStatistics.DataSource = JsonConvert.DeserializeObject<List<object>>
                    (new Sender().Receive("https://testerinho.com/vatrogasci/gettable.php?table=" + keyword));
                //obriši sve pointove dosad
                for (int i = chart.Series["Podaci"].Points.Count - 1; i >= 0 ; i--)
                {
                    chart.Series["Podaci"].Points.RemoveAt(i);
                }
                //dodaj nove podatke
                foreach (DataGridViewRow row in dgvStatistics.Rows)
                {
                    chart.Series["Podaci"].Points.AddXY(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Pogreška u dohvaćanju podataka! " + Environment.NewLine + e);
            }
        }

        private void lblOcjena_Click(object sender, EventArgs e)
        {
            chart.ChartAreas[0].Area3DStyle.Enable3D = true;
            chart.ChartAreas[0].AxisX.Interval = 1;
            chart.ChartAreas[0].AxisY.Interval = 1;
            chart.Series["Podaci"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            RefreshData("ProsječnaOcjena");
        }

        private void lblRezultati_Click(object sender, EventArgs e)
        {
            chart.ChartAreas[0].Area3DStyle.Enable3D = false;
            chart.ChartAreas[0].AxisX.Interval = 1;
            chart.ChartAreas[0].AxisY.Interval = 10;
            chart.Series["Podaci"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            RefreshData("Rezultati");
        }

        private void lblIntervencije_Click(object sender, EventArgs e)
        {
            chart.ChartAreas[0].Area3DStyle.Enable3D = true;
            chart.Series["Podaci"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            RefreshData("MjesecIntervencija");
        }

        private void lblPotrosnja_Click(object sender, EventArgs e)
        {
            chart.ChartAreas[0].Area3DStyle.Enable3D = false;
            chart.ChartAreas[0].AxisY.Interval = 0;
            chart.Series["Podaci"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart.Series["Podaci"].BorderWidth = 3;
            RefreshData("MjesecPotrošnje");
        }
    }
}
