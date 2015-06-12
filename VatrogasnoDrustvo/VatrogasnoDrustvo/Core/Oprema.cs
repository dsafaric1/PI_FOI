using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatrogasnoDrustvo.Core
{
    public class Oprema
    {

        public Oprema() { }

        public Oprema(System.Windows.Forms.DataGridViewRow row)
        {
            this.ID = int.Parse(row.Cells["Šifra"].Value.ToString());
            this.Naziv = row.Cells["Oprema"].Value.ToString();
            this.Kolicina = int.Parse(row.Cells["Količina"].Value.ToString());
            this.Godiste = int.Parse(row.Cells["Godište"].Value.ToString());
        }
        public int ID { get; set; }
        public string Naziv { get; set; }
        public int Kolicina { get; set; }
        public int Godiste { get; set; }

        public override string ToString()
        {
            return this.Naziv;
        }
    }
}
