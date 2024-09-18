using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Worker : Employee
    {




        public double Wage { get; set; }
        public Worker (string name, double wage):base(name)
        {


            Wage = wage;

        }

        public override string ToString ()



        {
            return $"Worker: Name = {Name}, Wage = {Wage}, , Vacation = {vacationDays}";
        }

        public override void TakeVacation()
        {
            vacationDays += 5;
        }
    }
}
