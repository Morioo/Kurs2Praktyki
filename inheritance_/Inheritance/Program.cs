using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee marcin = new Employee("Marcin");
            Worker jacek = new Worker("Jacek",100);
            Employee ola = new Manager("Ola");
            //jacek.vacationDays = 0;
            //Console.WriteLine(marcin.ToString());
            //Console.WriteLine(jacek.ToString());



            //jacek.TakeVacation();
            //marcin.TakeVacation();




            List<Employee> employess = new List<Employee>()
            {



                ola,
                jacek,
                marcin
            };

            foreach (Employee item in employess)
            {
                item.TakeVacation();
                Console.WriteLine(item.ToString());
            }
        }
    }
}
