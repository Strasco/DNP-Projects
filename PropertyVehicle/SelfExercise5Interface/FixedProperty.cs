using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfExercise5Interface
{
    class FixedProperty
    {
        protected string location;
        protected bool inCity;
        protected static decimal estimatedValue;

        public FixedProperty(String location, bool inCity, decimal estimatedValueCon)
        {
            this.location = location;
            this.inCity = inCity;
            estimatedValue = estimatedValueCon;
        }
    }
}
