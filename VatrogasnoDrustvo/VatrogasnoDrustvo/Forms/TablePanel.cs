using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VatrogasnoDrustvo.Forme;
using VatrogasnoDrustvo.InputForms;
using System.Reflection;

namespace VatrogasnoDrustvo
{
    /**
     * User kontrola za tablični prikaz kod ostalih formi.
     */
    public partial class TablePanel : UserControl
    {
        public TablePanel()
        {
            InitializeComponent();
        }

        /**
         * Metoda koja miče sve EventHandlere iz gumbića. Potrebno jer se svakim pozivom
         * metode initButton kači EventHandler i tada se otvara više istih prozora.
         */
        private void RemoveAllHandlers(Button btn)
        {
            FieldInfo f1 = typeof(Control).GetField("EventClick", BindingFlags.Static | BindingFlags.NonPublic);
            object obj = f1.GetValue(btn);
            PropertyInfo pi = btn.GetType().GetProperty("Events", BindingFlags.NonPublic | BindingFlags.Instance);
            EventHandlerList list = (EventHandlerList)pi.GetValue(btn, null);
            list.RemoveHandler(obj, list[obj]);
        }

        /**
         * Metoda za iniciranje gumbića. Neki gumbići su po zadanim postavkama skriveni
         * pa ih treba prikazati i dodati im ime i EventHandlera za OnClick event.
         */
        private void initButton(Button btn, String buttonName, EventHandler method)
        {
            btn.Text = buttonName;
            btn.Visible = true;
            RemoveAllHandlers(btn);
            btn.Click += method;
        }

        /**
         * Metoda koja skriva gumbiće koji nisu zadani (ona dva koji nisu Dodaj)
         */
        private void hideDegrees()
        {
            btnFirstDegree.Visible = false;
            btnSecondDegree.Visible = false;
        }

        /**
         * Metoda koja ažurira tablicu kod pretrage. TBI
         */
        public void updateDataGridView(String searchTerm) 
        { 

        }

        /**
         * Metoda za refresh forme koja sadrži DataGridView. Još bu trebalo dodati da ažurira sadržaj tablice (posebna metoda).
         * Ovisno o formi koja je otvorena, treba staviti gumbiće da su vidljivi i promjeniti labelu, a ne smijemo zaboraviti
         * niti EventHandlere na gumbićima koji su se tek postavili u vidljive.
         */
        public void refresh(String keyword)
        {
            hideDegrees();
            if (keyword == "Oprema")
            { 
                initButton(btnFirstDegree, "Ispis narudžbi", IspisNarudzbi_Click);
            }
            else if (keyword == "Natjecanja")
            {
                initButton(btnFirstDegree, "Prijavi se", Prijavi_ekipu_natjecanje_Click);
            }
            else if (keyword == "Narudžbe")
            {
                initButton(btnFirstDegree, "Generiraj PDF", null);
                initButton(btnSecondDegree, "Dobavljači", Dobavljac_Click);
            }
            lblBase.Text = keyword;
        }

        /**
         * Otvara se forma s narudžbama kada klikne na gumb Ispis narudžbi u formi za opreme.
         */
        private void IspisNarudzbi_Click(object sender, EventArgs e)
        {
            NarudzbeForma frmNarudzbe = new NarudzbeForma();
            frmNarudzbe.Show();
        }

        /**
         * Otvara formu s dobavljačima kada klikne na gumb Dobavljači u formi s narudžbama.
         */
        private void Dobavljac_Click(object sender, EventArgs e)
        {
            DobavljaciForma frmDobavljaci = new DobavljaciForma();
            frmDobavljaci.Show();
        }

        /**
         * Otvori prijavu na natjecanje kada klikne na gumb prijavi se u formi za natjecanja.
         * Treba dodati da mora natjecanje biti odabrano prethodno.
         */
        private void Prijavi_ekipu_natjecanje_Click(object sender, EventArgs e)
        {
            PodaciPrijava frmPrijava = new PodaciPrijava();
            frmPrijava.Show();
        }

        /**
         * Ovo je univerzalni gumbić Dodaj koji se prikazuje na svim formama. Budući da svaka forma
         * otvara drukčiju formu, onda se parsa labela na vrhu i ovisno o njoj se otvaraju zadane forme.
         */
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (lblBase.Text == "Članovi") openForm(new PodaciClana());
            else if (lblBase.Text == "Intervencije") openForm(new PodaciIntervencije());
            else if (lblBase.Text == "Oprema") openForm(new PodaciOpreme());
            else if (lblBase.Text == "Natjecanja") openForm(new PodaciNatjecanje());
            else if (lblBase.Text == "Dobavljači") openForm(new PodaciDobavljaca());
        }

        /**
         * Metoda koja otvara formu. Zasad ima samo frm.Show(), ali je odvojena zbog mogućih potreba
         * da se ne može preći na parent formu dok je ova TopLevel forma otvorena.
         */
        private void openForm(Form frm)
        {
            frm.Show();
        }
    }
}
