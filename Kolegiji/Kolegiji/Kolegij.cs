using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolegiji
{
    class Kolegij
    {
        public static List<Kolegij> SviKolegiji = new List<Kolegij>();
        public List<int> OcjeneKolegija = new List<int>();
        public string NazivKolegija { get; set; }
        public double Prosjek { get; set; }

        public Kolegij(string naziv)
        {
            NazivKolegija = naziv;
            SviKolegiji.Add(this);
        }
        public static Kolegij NadiKolegij(string naziv)
        {
            Kolegij vrijednostZaVratiti = null;
            foreach (var kolegij in SviKolegiji)
            {
                if (kolegij.NazivKolegija.ToLower().Equals(naziv.ToLower()))
                    vrijednostZaVratiti = kolegij;
            }
            return vrijednostZaVratiti;
        }
        public static Kolegij NajlosijiKolegij()
        {
            Kolegij vrijednostZaVratiti = null;
            List<Kolegij> sortiranaLista = SviKolegiji.OrderBy(p => p.Prosjek).ToList();
            vrijednostZaVratiti = sortiranaLista[0];
            return vrijednostZaVratiti;
        }
        public static Kolegij NajboljiKolegij()
        {
            Kolegij vrijednostZaVratiti = null;
            List<Kolegij> sortiranaLista = SviKolegiji.OrderBy(p => p.Prosjek).ToList();
            vrijednostZaVratiti = sortiranaLista[sortiranaLista.Count-1];
            return vrijednostZaVratiti;
        }
    }
}
