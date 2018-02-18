using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Car : IComparable
    {
        private int engine;
        private double weight;
        private int topSpeed;


        public Car(int engine, double weight, int topSpeed)
        {
            this.engine = engine;
            this.weight = weight;
            this.topSpeed = topSpeed;
        }

        
        public override String ToString()
        {
            return "E: " + engine + " W: "  + weight + " TS: " + topSpeed;

        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }


    }
}
