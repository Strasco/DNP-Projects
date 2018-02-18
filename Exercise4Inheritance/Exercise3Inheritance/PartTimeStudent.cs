using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3Inheritance
{
    class PartTimeStudent : PartTimeEmployee, IStudent
    {

        private int year;

        public PartTimeStudent(string name, int hoursPerMonth, double hourlyWage)
            : base (name, hoursPerMonth, hourlyWage) { }

        public void Register(int year)
        {
            this.year = year;
        }
    }

        
        
    
}
