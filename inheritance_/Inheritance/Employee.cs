using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{






    class Employee
    {
        protected int vacationDays;
        public string Name { get; set; }

        public Employee(string name)




        {
            Name = name;
        }
        public override string ToString()
        {
            return $"Employee: Name = {Name}";


        }


        public virtual void TakeVacation()
        {
            
        }
    }
}
