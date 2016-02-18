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
using VatrogasnoDrustvo.Forme;

namespace VatrogasnoDrustvo.InputForms
{
    /// <summary>
    /// Forma za unos nove opreme
    /// </summary>
    public partial class PodaciOpreme : Form
    {
        private Oprema oprema;
        private Pumpa pumpa;
        private Vozilo vozilo;

        public PodaciOpreme()
        {
            InitializeComponent();
            comboBox1.DataSource = new List<string> { "Oprema", "Vozilo", "Pumpa" };
            cmbTip.DataSource = Enum.GetValues(typeof(TipVozila)).Cast<TipVozila>().ToList();
        }

        /// <summary>
        /// Konstruktor za update, generira objekte ovisno o tipu
        /// </summary>
        /// <param name="row">Redak koji je kliknut</param>
        public PodaciOpreme(DataGridViewRow row)
        {
            InitializeComponent();
            comboBox1.DataSource = new List<string> { "Oprema", "Vozilo", "Pumpa" };
            cmbTip.DataSource = Enum.GetValues(typeof(TipVozila)).Cast<TipVozila>().ToList();
            comboBox1.Enabled = false;
            comboBox1.SelectedIndex = comboBox1.FindString(row.Cells["Tip opreme"].Value.ToString());
            if(row.Cells["Tip opreme"].Value.ToString() == "Vozilo")
            {
                vozilo = AddVozilo(row);
                txtNaziv.Text = vozilo.Naziv;
                numKolicina.Value = vozilo.Kolicina;
                numGodiste.Value = vozilo.Godiste;
                numericUpDown1.Value = vozilo.BrojSjedala;
                numericUpDown2.Value= vozilo.ZapremninaVode;
                cmbTip.SelectedIndex = cmbTip.FindString(vozilo.TipVozila.ToString());
                numJacina.Value = vozilo.Jacina;
                numTezina.Value = decimal.Parse(vozilo.Tezina.ToString());
            }
            else if(row.Cells["Tip opreme"].Value.ToString() == "Pumpa"){
                
                pumpa = AddPumpa(row);
                numGodiste.Value = pumpa.Godiste;
                numKolicina.Value = pumpa.Kolicina;
                numJacina.Value = pumpa.Jacina;
                numericUpDown1.Value = pumpa.MaxProtok;
                numericUpDown2.Value = pumpa.MaxVisinaPumpanja;
                numTezina.Value = pumpa.Tezina;
                txtNaziv.Text = pumpa.Naziv;

            }
            else if(row.Cells["Tip opreme"].Value.ToString() == "Oprema"){
                oprema = AddOprema(row);
                txtNaziv.Text = oprema.Naziv;
                numKolicina.Value = oprema.Kolicina;
                numGodiste.Value = oprema.Godiste;
            }
        }

        private Oprema AddOprema(DataGridViewRow row)
        {
            if (row == null) oprema = new Oprema();
            else oprema = new Oprema(row);
            return oprema;
        }

        private Pumpa AddPumpa(DataGridViewRow row)
        {
            if (row == null) pumpa = new Pumpa();
            else pumpa = new Pumpa(row);
            return pumpa;
        }

        private Vozilo AddVozilo(DataGridViewRow row)
        {
            if (row == null) vozilo = new Vozilo();
            else vozilo = new Vozilo(row);
            return vozilo;
        }

        /// <summary>
        /// Ovisno o selektiranoj vrijednosti combobox kontrole, generiraju se ostali textboxovi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Vozilo":
                    lblJacina.Visible = true;
                    lblTezina.Visible = true;
                    numJacina.Visible = true;
                    numTezina.Visible = true;
                    lblTip.Visible = true;
                    cmbTip.Visible = true;
                    lblFirstDeg.Text = "Broj sjedala:";
                    lblFirstDeg.Visible = true;
                    lblSecondDeg.Text = "Zapremnina vode:";
                    lblSecondDeg.Visible = true;
                    numericUpDown1.Visible = true;
                    numericUpDown2.Visible = true;
                    break;
                case "Oprema": 
                    lblJacina.Visible = false;
                    lblTezina.Visible = false;
                    numJacina.Visible = false;
                    numTezina.Visible = false;
                    lblTip.Visible = false;
                    cmbTip.Visible = false;
                    lblFirstDeg.Visible = false;
                    lblSecondDeg.Visible = false;
                    numericUpDown1.Visible = false;
                    numericUpDown2.Visible = false;
                    break;
                case "Pumpa":
                    lblJacina.Visible = true;
                    lblTezina.Visible = true;
                    numJacina.Visible = true;
                    numTezina.Visible = true;
                    lblFirstDeg.Text = "Max protok:";
                    lblFirstDeg.Visible = true;
                    lblSecondDeg.Text = "Max visina:";
                    lblSecondDeg.Visible = true;
                    numericUpDown1.Visible = true;
                    numericUpDown2.Visible = true;
                    lblTip.Visible = false;
                    cmbTip.Visible = false;
                    break;
            }
        }

        /// <summary>
        /// Kreiranje objekta tipa oprema
        /// </summary>
        /// <param name="oprema">Prosljeđena oprema</param>
        /// <returns>Nova oprema</returns>
        private Oprema getOprema(Oprema oprema)
        {
            if(oprema == null) oprema = new Oprema();
            oprema.Naziv = txtNaziv.Text;
            oprema.Kolicina = int.Parse(numKolicina.Value.ToString());
            oprema.Godiste = int.Parse(numGodiste.Value.ToString());
            return oprema;
        }

        private Vozilo getVozilo(Vozilo vozilo)
        {
            if(vozilo == null) vozilo = new Vozilo();
            vozilo.Naziv = txtNaziv.Text;
            vozilo.Kolicina = int.Parse(numKolicina.Value.ToString());
            vozilo.Godiste = int.Parse(numGodiste.Value.ToString());
            vozilo.BrojSjedala = int.Parse(numericUpDown1.Value.ToString());
            vozilo.ZapremninaVode = int.Parse(numericUpDown2.Value.ToString());
            vozilo.TipVozila = (TipVozila)Enum.Parse(typeof(TipVozila), cmbTip.Text);
            vozilo.Jacina = int.Parse(numJacina.Value.ToString());
            vozilo.Tezina = int.Parse(numTezina.Value.ToString());
            return vozilo;
        }

        private Pumpa getPumpa(Pumpa pumpa)
        {
            if (pumpa == null) pumpa = new Pumpa();
            pumpa.Godiste = int.Parse(numGodiste.Value.ToString());
            pumpa.Kolicina = int.Parse(numKolicina.Value.ToString());
            pumpa.Jacina = int.Parse(numJacina.Value.ToString());
            pumpa.MaxProtok = int.Parse(numericUpDown1.Value.ToString());
            pumpa.MaxVisinaPumpanja = int.Parse(numericUpDown2.Value.ToString());
            pumpa.Tezina = int.Parse(numTezina.Value.ToString());
            pumpa.Naziv = txtNaziv.Text;
            return pumpa;
        }
        private void btnSalji_Click(object sender, EventArgs e)
        {
            //ako su ispunjena sva polja
            if (txtNaziv.Text != "" && cmbTip.SelectedValue.ToString() != "" )
            {
                //opremu povučeno iz retka
                if (oprema == null && vozilo == null && pumpa ==null)
                {
                    executeOprema("http://46.101.122.250/insertOprema.php");
                }
                else
                {
                    executeOprema("http://46.101.122.250/updateOprema.php");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Nisu ispunjena sva polja!");
            }
        }

        /// <summary>
        /// Povlačenje podataka za redak kako bi se kreirao novi objekt
        /// </summary>
        /// <param name="URL">URL na koji se šalje objekt</param>
        private void executeOprema(string URL)
        {
            if(oprema != null || comboBox1.Text == "Oprema"){
                oprema = getOprema(oprema);
                Dictionary<string,string> Tip = new Dictionary<string,string>{
                    {"tip","Oprema"}
                };
                sendData(oprema, URL, Tip);
            }
            else if(vozilo != null || comboBox1.Text == "Vozilo"){
                vozilo =getVozilo(vozilo);
                Dictionary<string,string> Tip = new Dictionary<string,string>{
                    {"tip","Vozilo"}
                };
                sendData(vozilo, URL, Tip);
            }
            else if (pumpa != null || comboBox1.Text == "Pumpa")
            {
                pumpa = getPumpa(pumpa);
                Dictionary<string, string> Tip = new Dictionary<string, string>{
                    {"tip","Pumpa"}
                };
                sendData(pumpa, URL, Tip);
            }
        }

        /// <summary>
        /// Slanje objekta na URL
        /// </summary>
        /// <param name="oprema">objekt koji šalje</param>
        /// <param name="URL">URL na koji šalje</param>
        /// <param name="Tip">tip opreme koji se šalje</param>
        private void sendData(object oprema, string URL, Dictionary<string, string> Tip)
        {
            try
            {
                //MessageBox.Show(new Sender().Send(oprema, URL, Tip));
                var response = JsonConvert.DeserializeObject<Dictionary<string, object>>
                    (new Sender().Send(oprema, URL, Tip));

                if (bool.Parse(response["passed"].ToString()))
                {
                    MessageBox.Show("Uspješan unos opreme!");
                }
                else
                {
                    MessageBox.Show(response["text"].ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Pogreška u kontaktiranju servera " + e.ToString());
            }
        }

    }
}
