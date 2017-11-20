using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenia_nr_6_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kwadrat kwadrat1 = new Kwadrat(2);
            //Trojkat trojkat1 = new Trojkat(1,2,3);
            //Console.WriteLine(kwadrat1.ObliczPole());
            //Console.WriteLine(trojkat1.ObliczPole());

            List<Figura> figury = new List<Figura>();
            figury.Add(new Kwadrat(5));
            figury.Add(new Trojkat(3, 6, 4));
            figury.Add(new Kwadrat(7.2));

            figury.Add(new Trojkat(12, 5, 13));

            foreach (var element in figury)
            {
                Console.WriteLine(element.ObliczPole());
            }
            Console.ReadKey();
        }
    }
}
