using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Facade
{
    public class Mortgage
    {
        Bank bank = new Bank();
        Loan loan = new Loan();
        Credit credit = new Credit();

        public bool IsEligible(Customer customer, double amount)
        {
            Console.WriteLine($"{customer.Name} asking for {amount} loan");
            bool eligible = true;


            //check if the customer's loan will be agreed

            if (!bank.HasEnoughSavings(customer, amount))
            {
                eligible = false;
            }
            else if (!loan.HasNoBadLoans(customer))
            {
                eligible = false;
            }
            else if (!credit.HasGoodCredit(customer))
            {
                eligible = false;
            }
            return eligible;
        }
    }
}
