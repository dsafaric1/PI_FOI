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
    public partial class TablePanel : UserControl
    {
        public TablePanel()
        {
            InitializeComponent();
        }

        private void RemoveAllHandlers(Button btn)
        {
            FieldInfo f1 = typeof(Control).GetField("EventClick", BindingFlags.Static | BindingFlags.NonPublic);
            object obj = f1.GetValue(btn);
            PropertyInfo pi = btn.GetType().GetProperty("Events", BindingFlags.NonPublic | BindingFlags.Instance);
            EventHandlerList list = (EventHandlerList)pi.GetValue(btn, null);
            list.RemoveHandler(obj, list[obj]);
        }

        private void initButton(Button btn, String buttonName, EventHandler method)
        {
            btn.Text = buttonName;
            btn.Visible = true;
            RemoveAllHandlers(btn);
            btn.Click += method;
        }

        private void hideDegrees()
        {
            btnFirstDegree.Visible = false;
            btnSecondDegree.Visible = false;
        }

        public void updateDataGridView(String searchTerm) 
        { 

        }

        /**
         * Metoda za refresh forme koja sadrži DataGridView. Još bu trebalo dodati da ažurira sadržaj tablice.
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

        private void IspisNarudzbi_Click(object sender, EventArgs e)
        {
            NarudzbeForma frmNarudzbe = new NarudzbeForma();
            frmNarudzbe.Show();
        }

        private void Dobavljac_Click(object sender, EventArgs e)
        {
            DobavljaciForma frmDobavljaci = new DobavljaciForma();
            frmDobavljaci.Show();
        }

        private void Prijavi_ekipu_natjecanje_Click(object sender, EventArgs e)
        {
            PodaciPrijava frmPrijava = new PodaciPrijava();
            frmPrijava.Show();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (lblBase.Text == "Članovi") openForm(new PodaciClana());
            else if (lblBase.Text == "Intervencije") openForm(new PodaciIntervencije());
            else if (lblBase.Text == "Oprema") openForm(new PodaciOpreme());
            else if (lblBase.Text == "Natjecanja") openForm(new PodaciNatjecanje());
            else if (lblBase.Text == "Dobavljači") openForm(new PodaciDobavljaca());
        }

        private void openForm(Form frm)
        {
            frm.Show();
        }
    }
}
