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
    /// Glavna forma koja se otvara nakon prijave. Ima na vrhu
    /// ToolStrip objekt s poveznicama za promjenu prikaza panela.
    /// </summary>
    public partial class GlavnaForma : Form
    {
        public Vatrogasac TrenutniVatrogasac { get; set; }

        public GlavnaForma(Vatrogasac mirko)
        {
            InitializeComponent();
            TrenutniVatrogasac = mirko;
            Label vatroIme = pnlGlavna.Controls.Find("lblPrijavljenIme", true).FirstOrDefault() as Label;
            Label vatroZvanje = pnlGlavna.Controls.Find("lblZvanje", true).FirstOrDefault() as Label;
            vatroIme.Text = TrenutniVatrogasac.Ime + " " + TrenutniVatrogasac.Prezime;
            vatroZvanje.Text = TrenutniVatrogasac.Zvanje.ToString();
            this.FormClosed += GlavnaForma_FormClosed; //Glavna forma nije zapravo glavna pa treba gasiti cijelu aplikaciju ručno
            tlstrplblPocetna_Click(null, null); //Potrebno da se na početku prikaže panel s dobrodošlicom
        }

        /// <summary>
        /// Handler za gašenje aplikacije prilikom gašenja glavne forme.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GlavnaForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
            exchange("Intervencije");   
        }

        /// <summary>
        /// Metoda koja obrađuje OnClick na labelu članovi u ToolStrip objektu.
        /// Metoda exchange objašnjena je niže.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlstrplblClanovi_Click(object sender, EventArgs e)
        {
            exchange("Članovi");
        }

        /// <summary>
        /// Metoda koja obrađuje OnClick na labelu oprema u ToolStrip objektu.
        /// Metoda exchange objašnjena je niže.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlstrplblOprema_Click(object sender, EventArgs e)
        {
            exchange("Oprema");
        }

        /// <summary>
        ///  Metoda koja TablePanel pomakne napred do korisnika, a nakon toga
        /// poziva internu metodu refresh (implementirana u klasi TablePanel) koja
        /// prima string parametar, a rezultira promjenom interne labele i gumbića te
        /// njihovih EventHandlera (u TablePanel kontroli). Kad je sve obavljeno poziva
        /// se metoda Refresh implementirana u klasi Control za osvježavanje kontrole.
        /// </summary>
        /// <param name="keyword"></param>
        private void exchange(string keyword)
        {
            pnlTable.BringToFront();
            pnlTable.refresh(keyword);
            pnlTable.Refresh();
        }

        /// <summary>
        /// Metoda koja obrađuje OnClick na labelu natjecanja u ToolStrip objektu.
        /// Metoda exchange objašnjena je iznad.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlstrplblNatjecanja_Click(object sender, EventArgs e)
        {
            exchange("Natjecanja");
        }
    }
}
