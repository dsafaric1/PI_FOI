using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VatrogasnoDrustvo.Core
{
    class Pumpa:Oprema
    {

        public Pumpa() { }

        public Pumpa(DataGridViewRow row)
        {
            this.ID = int.Parse(row.Cells["Šifra"].Value.ToString());
            this.Naziv = row.Cells["Oprema"].Value.ToString();
            this.Kolicina = int.Parse(row.Cells["Količina"].Value.ToString());
            this.Godiste = int.Parse(row.Cells["Godište"].Value.ToString());
            this.Jacina = int.Parse(row.Cells["Jačina"].Value.ToString());
            this.Tezina = int.Parse(row.Cells["Težina"].Value.ToString());
            this.MaxProtok = int.Parse(row.Cells["Max protok"].Value.ToString());
            this.MaxVisinaPumpanja = int.Parse(row.Cells["Max visina pumpanja"].Value.ToString());
        }

        public int MaxProtok { get; set; }
        public Decimal MaxVisinaPumpanja { get; set; }
        public int Jacina { get; set; }
        public Decimal Tezina { get; set; }
    }
}
