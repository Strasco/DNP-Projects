using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3Inheritance
{
    class Company
    {
        private List<Employee> employees;

        public Company()
        {
            employees = new List<Employee>();
        }

        public double GetMonthlySalaryTotal()
        {
            double total = 0;
            for (int i = 0; i < employees.Count; i++)
            {
                total += employees[i].GetMonthSalary();
            }
            return total;
        }

        public void employNewEmployee(Employee employee)
        {
            employees.Add(employee);
        }

    }
}
