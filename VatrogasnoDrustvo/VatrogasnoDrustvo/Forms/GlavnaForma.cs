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
     * Glavna forma koja se otvara nakon prijave. Ima na vrhu
     * ToolStrip objekt s poveznicama za promjenu prikaza panela.
     */
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
            tlstrplblPocetna_Click(null, null); //Potrebno da se na početku prikaže panel s dobrodošlicom
        }

        /**
         * Metoda koja obrađuje OnClick na labelu početna u ToolStrip objektu.
         * Dovoljno je panel s dobrodošlicom gurnuti napred do korisnika.
         */
        private void tlstrplblPocetna_Click(object sender, EventArgs e)
        {
            pnlGlavna.BringToFront();
        }

        /**
         * Metoda koja obrađuje OnClick na labelu intervencije u ToolStrip objektu.
         * Metoda exchange objašnjena je niže.
         */
        private void tlstrplblIntervencije_Click(object sender, EventArgs e)
        {
            exchange("Intervencije");   
        }

        /**
         * Metoda koja obrađuje OnClick na labelu članovi u ToolStrip objektu.
         * Metoda exchange objašnjena je niže.
         */
        private void tlstrplblClanovi_Click(object sender, EventArgs e)
        {
            exchange("Članovi");
        }

        /**
         * Metoda koja obrađuje OnClick na labelu oprema u ToolStrip objektu.
         * Metoda exchange objašnjena je niže.
         */
        private void tlstrplblOprema_Click(object sender, EventArgs e)
        {
            exchange("Oprema");
        }

        /**
         * Metoda koja TablePanel pomakne napred do korisnika, a nakon toga
         * poziva internu metodu refresh (implementirana u klasi TablePanel) koja
         * prima string parametar, a rezultira promjenom interne labele i gumbića te
         * njihovih EventHandlera (u TablePanel kontroli). Kad je sve obavljeno poziva
         * se metoda Refresh implementirana u klasi Control za osvježavanje kontrole.
         */
        private void exchange(string keyword)
        {
            pnlTable.BringToFront();
            pnlTable.refresh(keyword);
            pnlTable.Refresh();
        }

        /**
         * Metoda koja obrađuje OnClick na labelu natjecanja u ToolStrip objektu.
         * Metoda exchange objašnjena je iznad.
         */
        private void tlstrplblNatjecanja_Click(object sender, EventArgs e)
        {
            exchange("Natjecanja");
        }
    }
}
