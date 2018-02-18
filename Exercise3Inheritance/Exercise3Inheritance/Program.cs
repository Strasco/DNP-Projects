using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Company co = new Company();
            co.employNewEmployee(new FullTimeEmployee("Vlad", 10000));
            co.employNewEmployee(new PartTimeEmployee("Alex", 15, 12));

            Console.WriteLine(co.GetMonthlySalaryTotal() + " bew");
            Console.ReadKey();
            
                
        }
    }
}
