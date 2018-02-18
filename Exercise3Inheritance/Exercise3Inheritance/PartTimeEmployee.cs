using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3Inheritance
{
    class PartTimeEmployee : Employee
    {
        private double hourlyWage;
        private int hoursPerMonth;


        public PartTimeEmployee(string name, int hoursPerMonth, double hourlyWage)
               : base (name)
        {
            this.hoursPerMonth = hoursPerMonth;
            this.hourlyWage = hourlyWage;
        }

        
        
        public override double GetMonthSalary()
        {
            return hoursPerMonth * hourlyWage;
        }
    }
}
