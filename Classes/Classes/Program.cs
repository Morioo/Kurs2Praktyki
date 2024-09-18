using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "Avensis";
            myCar.Year = 1999;
            Console.WriteLine($"First car is: {myCar.Make} , {myCar.Model}" +
                $" , {myCar.DetermineValue()}");

            //Car.Move();

            Car myOtherCar = new Car();
            myOtherCar.Model = "Punto";
            myOtherCar.Color = "Czerwone";

            Console.WriteLine($"Second car is: {myOtherCar.Make} , {myOtherCar.Color}");

            myOtherCar = null;

            Car mySecondCar = new Car("Nissan");

            mySecondCar.Year = 2005;

            Console.WriteLine($"The last car is: {mySecondCar.Make}," +
                $" {mySecondCar.DetermineValue()}");
        }

    }
}
