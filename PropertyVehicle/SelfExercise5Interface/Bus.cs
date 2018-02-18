using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfExercise5Interface
{
    class Bus : Vehicle, ITaxable
    {

        protected static int numberOfSeats;
        

        public Bus(int seats, int registrationNumber, double maxVelocity, decimal value)
            : base (registrationNumber, maxVelocity, value)
        {
            numberOfSeats = seats;
        }
        public decimal TaxValue()
        {
            double d = (numberOfSeats + (numberOfSeats * 0.1)) * (double)value;
            return (decimal)d;
        }
    }
}
