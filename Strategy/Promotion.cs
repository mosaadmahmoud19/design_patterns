using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Promotion : RaiseStrategy
    {
        public override void RaiseType(Employee emp)
        {
            emp.Salary = emp.Salary + (emp.Salary * 0.1);
            Console.WriteLine("Enter the new job title: ");
            emp.Title = Console.ReadLine();
            Console.WriteLine("Salary Increased by 10%");
        }
    }
}
