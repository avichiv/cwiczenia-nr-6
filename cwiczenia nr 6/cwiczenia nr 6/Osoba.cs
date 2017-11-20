using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenia_nr_6
{
    class Osoba
    {
        public string imie;
        public string nazwisko;
        public Osoba()
        {
            this.imie = "Jan";
            this.nazwisko = "Janowicz";
        }
        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
        public virtual void WypiszInfo()
        {
            Console.WriteLine("Imie i nazwisko: {0} {1}", imie, nazwisko);
        }
        public override string ToString()
        {
            return String.Format("");
        }
    }
}
