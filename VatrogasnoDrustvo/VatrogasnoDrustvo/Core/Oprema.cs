using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatrogasnoDrustvo.Core
{
    public class Oprema
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public int Kolicina { get; set; }

        public override string ToString()
        {
            return this.Naziv;
        }
    }
}
