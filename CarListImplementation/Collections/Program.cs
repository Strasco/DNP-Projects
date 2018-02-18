using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<Car> cars = new List<Car>();
            
            for (int i = 0; i < 10; i++)
            {

                cars.Add(new Car(rnd.Next(1600, 5000), rnd.Next(1000, 4000), rnd.Next(160, 250)));
            }
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine(cars[i].ToString());
            }
            Console.ReadKey();
        }
    }
}
