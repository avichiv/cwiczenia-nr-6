using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenia_nr_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Osoba student1 = new Student();
            student1.WypiszInfo(); //wykonalo sie z klasy bazowej
            Console.ReadKey();
            
        }
    }
}
