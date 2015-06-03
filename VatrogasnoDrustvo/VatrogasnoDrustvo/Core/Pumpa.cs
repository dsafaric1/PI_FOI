using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatrogasnoDrustvo.Core
{
    class Pumpa:Oprema
    {
        public int MaxProtok { get; set; }
        public Decimal MaxVisinaPumpanja { get; set; }
        public int Jacina { get; set; }
        public Decimal Tezina { get; set; }
    }
}
