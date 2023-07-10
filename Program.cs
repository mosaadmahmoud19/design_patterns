using Patterns.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton Test
            Manager m1 = Manager.Instance();
            Manager m2 = Manager.Instance();
            if (m1 == m2)
            {
                Console.WriteLine("They are the same manger");
            }

            //Strategy Pattern Test
            Employee emp;

            emp = new Employee("Ali", 32, "Accountant", 10000, new Promotion());
            emp.Raise();
            Console.WriteLine($"New salary is : {emp.Salary}");

            emp = new Employee("Ali", 32, "Accountant", 10000, new GoodNumbers());
            emp.Raise();
            Console.WriteLine($"New salary is : {emp.Salary}");

            emp = new Employee("Ali", 32, "Accountant", 10000, new Annually());
            emp.Raise();
            Console.WriteLine($"New salary is : {emp.Salary}");

            //Facede Test
            
            //creating lending object
            Mortgage mortgage = new Mortgage();

            //evaluate if the customer can use lending service

            Customer customer = new Customer("Ali Waleed");
            bool eligible = mortgage.IsEligible(customer, 125000);
            Console.WriteLine($"{customer.Name} has been {(eligible ? "Approved" : "Rejected")}");
            


            Console.ReadKey();

        }
    }
}
