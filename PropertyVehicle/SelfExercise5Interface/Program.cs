using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SelfExercise5Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus b = new Bus(10, 102030, 100, 500);
            House h = new House("Horsens", false, 10000, 300);

            Console.WriteLine(b.TaxValue());
            Console.WriteLine(h.TaxValue());
            Console.ReadKey();

        }
    }
}
