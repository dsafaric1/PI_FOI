using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatrogasnoDrustvo.Core
{
    public class StavkaNarudzbe
    {
        public Oprema NarucenaOprema { get; set; }
        public string JedinicaMjera { get; set; }
        public int Kolicina { get; set; }
        public Decimal Cijena { get; set; }

        public StavkaNarudzbe()
        {

        }

        public Decimal GetUkupnaCijena() 
        {
            return this.Kolicina * this.Cijena;
        }
    }
}
