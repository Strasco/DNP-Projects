using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfExercise5Interface
{
    class Vehicle
    {
        protected int registrationNumber;
        protected double maxVelocity;
        protected static decimal value;

        public Vehicle (int registrationNumber, double maxVelocity, decimal valueC)
        {
            this.registrationNumber = registrationNumber;
            this.maxVelocity = maxVelocity;
            value = valueC;
        }


    }
}
