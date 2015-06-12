using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VatrogasnoDrustvo.Core
{
    public enum TipVozila
    {
        Zapovjedno,
        Navalno,
        Tehnicko,
        Autoljestve,
        Autocisterna,
        Platforma,
        Specijalno
    }

    public class Vozilo:Oprema
    {

        public Vozilo() { }

        public Vozilo(DataGridViewRow row)
        {
            this.BrojSjedala=int.Parse(row.Cells["Broj sjedala"].Value.ToString());
            this.ID=int.Parse(row.Cells["Šifra"].Value.ToString());
            this.Kolicina = int.Parse(row.Cells["Količina"].Value.ToString());
            this.Godiste = int.Parse(row.Cells["Godište"].Value.ToString());
            this.ZapremninaVode = int.Parse(row.Cells["Zapremnina vode"].Value.ToString());
            this.tipVozila=(TipVozila)Enum.Parse(typeof(TipVozila),row.Cells["Tip vozila"].Value.ToString());
            this.Naziv=row.Cells["Oprema"].Value.ToString();
            this.Jacina = int.Parse(row.Cells["Jačina"].Value.ToString());
            this.Tezina = int.Parse(row.Cells["Težina"].Value.ToString());
        }
        
        public int BrojSjedala { get; set; }
        public TipVozila tipVozila { get; set; }
        public int ZapremninaVode { get; set; }
        public int Jacina { get; set; }
        public Decimal Tezina { get; set; }
    }
}
