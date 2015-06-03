using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatrogasnoDrustvo.Core
{
    class StavkaNarudzbe
    {
        public Oprema NarucenaOprema { get; set; }
        public string JedinicaMjera { get; set; }
        public int Kolicina { get; set; }
        private Decimal cijena;

        public Decimal GetUkupnaCijena() 
        {
            return this.Kolicina * this.cijena;
        }
    }
}
