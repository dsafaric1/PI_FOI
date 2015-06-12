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
    public partial class PodaciStavkeNarudzbe : Form
    {
        List<Oprema> stavke;
        public PodaciStavkeNarudzbe()
        {
            InitializeComponent();
            FillCheckbox();
        }
        //punjenje checkboxa podacima
        private void FillCheckbox()
        {
            var data = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>
                        (new Sender().Receive("https://testerinho.com/vatrogasci/gettable.php?table=Oprema"));
           
            stavke = new List<Oprema>();
            //uzima se naziv opreme i sprema u stavke
            foreach (var d in data)
            {
                stavke.Add(new Oprema { Naziv = d["Oprema"].ToString() });
            }
            //ispis naziva stavki u checkbox
            stavke.ForEach(s => clbPodaciStavkeNarudzbe.Items.Add(s.Naziv));
            
        }

        private void btnDodajStavke_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// dohvaca odabrane stavke i sprema ih u listu stavki
        /// </summary>
        /// <returns> vraca listu stavki</returns>

        public List<StavkaNarudzbe> SendChecked()
        {
            List<StavkaNarudzbe> listaStavki = new List<StavkaNarudzbe>();
            foreach (String items in clbPodaciStavkeNarudzbe.CheckedItems)
            {
                listaStavki.Add(new StavkaNarudzbe { NarucenaOprema = new Oprema { Naziv = items } });
            }
            return listaStavki;
        }


    }
}
