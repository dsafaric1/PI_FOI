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
    /// Forma za unos nove opreme
    /// </summary>
    public partial class PodaciOpreme : Form
    {
        public PodaciOpreme()
        {
            InitializeComponent();
            comboBox1.DataSource = new List<string> { "Oprema", "Vozilo", "Pumpa" };
            cmbTip.DataSource = Enum.GetValues(typeof(TipVozila)).Cast<TipVozila>().ToList();
        }

        /// <summary>
        /// Ovisno o selektiranoj vrijednosti combobox kontrole, generiraju se ostali textboxovi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedValue.ToString())
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
                    break;
                case "Oprema": 
                    lblJacina.Visible = true;
                    lblTezina.Visible = true;
                    numJacina.Visible = true;
                    numTezina.Visible = true;
                    lblFirstDeg.Text = "Max protok:";
                    lblFirstDeg.Visible = true;
                    lblSecondDeg.Text = "Max visina:";
                    lblSecondDeg.Visible = true;
                    break;
                case "Pumpa":
                    break;
            }
        }
    }
}
