using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Manager : Employee
    {
        public Manager(string name) : base(name)
        {

        }

        public override void TakeVacation()
        {
            vacationDays += 10;
        }



        public override string ToString()
        {
            return $"Manager: Name = {Name}, Vacation = {vacationDays}";
        }







    }
}
