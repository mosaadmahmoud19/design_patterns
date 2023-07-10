using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Facade
{

    //subsystem Class C
    class Bank
    {
        public bool HasEnoughSavings (Customer cutomer, double amount)
        {
            Console.WriteLine($"Check bank for {cutomer.Name}");
            return true;
        }
    }
}
