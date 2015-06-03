using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatrogasnoDrustvo.Core
{
    enum TipNatjecanja
    {
        Opcinsko,
        Zupanijsko,
        Memorijal,
        SpajanjeUsisnogVoda
    }

    class Natjecanje
    {
        private string naziv;
        public List<Ekipa> EkipeNatjecanja { get; set; }
        public string mjesto { get; set; }
        public DateTime VrijemeOdrzavanja { get; set; }
        public TipNatjecanja Tip { get; set; }
        public Decimal Cijena { get; set; }

        public void AddEkipa(Ekipa ekipa) 
        {
            EkipeNatjecanja.Add(ekipa);
        }

        public void RemoveEkipa(Ekipa ekipa)
        {
            EkipeNatjecanja.Remove(ekipa);
        }
    }
}
