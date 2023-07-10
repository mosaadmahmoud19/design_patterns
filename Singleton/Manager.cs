using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Manager
    {
        private string Name { get; set; }
        private int Age { get; set; }
        private double Salary { get; set; }

        protected Manager()
        {

        }

        public static Manager managerInstance;

        public static Manager Instance()
        {
            if (managerInstance == null)
            {
                managerInstance = new Manager();
            }
            return managerInstance;
        }


    }
}
