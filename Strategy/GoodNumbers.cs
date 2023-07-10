using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class GoodNumbers : RaiseStrategy
    {
        public override void RaiseType(Employee emp)
        {
            emp.Salary = emp.Salary + (emp.Salary * 0.05);
            Console.WriteLine("Salary Increased by 5%");
        }
    }
}
