using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3Inheritance
{
    public abstract class Employee
    {
        public string name { get; set; }

        public Employee(string name)
        {
            this.name = name;
        }

        

        public abstract double GetMonthSalary();
    }

    
}
