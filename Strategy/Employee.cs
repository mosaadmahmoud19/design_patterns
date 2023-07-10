using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Employee
    {
        RaiseStrategy Strategy;
        public string Name { get; set; }
        public int Age { get; set; }
        public string Title { get; set; }
        public double Salary { get; set; }

        public Employee(string name, int age, string title, double salary, RaiseStrategy strategy)
        {
            Name = name;
            Age = age;
            Title = title;
            Salary = salary;
            Strategy = strategy;
        }

        public void Raise()
        {
            Strategy.RaiseType(this);
        }
    }
}
