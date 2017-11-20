using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenia_nr_6
{
    class Student : Osoba
    {
        public int rokStudiow;
        public int numerGrupy;
        public int numerAlbumu;

        public Student()
        {

        }
        public Student(string imie, string nazwisko, int rokStudiow, int numerGrupy, int numerAlbumu)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokStudiow = rokStudiow;
            this.numerGrupy = numerGrupy;
            this.numerAlbumu = numerAlbumu;
        }
        public override void WypiszInfo() //new - zjawisko nadpisywania metody
        {
            Console.WriteLine("Imie i nazwisko: {0} {1}", imie, nazwisko);
            Console.WriteLine("Rok studiow i numer grupy: {0} {1}", rokStudiow, numerGrupy);
            Console.WriteLine("Numer albumu: {0}",numerAlbumu);
        }

        public override string ToString()
        {
        }
    }
}
