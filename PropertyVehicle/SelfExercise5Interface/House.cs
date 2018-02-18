using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfExercise5Interface
{
    
    class House :  FixedProperty, ITaxable
          
    {
        protected static double area;

        public House(string location, bool inCity, decimal estimatedValue, double areaCon)
            : base(location, inCity, estimatedValue)
        {
            area = areaCon;
        }
            public decimal TaxValue()
        {
            double d = area + (area * 0.1);
            return (decimal) d;
        }
    }
}
