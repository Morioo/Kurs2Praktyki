using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineValue()
        {
            decimal carValue;

            if (this.Year <= 2000)
                carValue = 100;
            else
                carValue = 200;
            return carValue;
        }

        public static void Move()
        {
            Console.WriteLine($"Moving... ");
            //Console.WriteLine($"Moving... {this.}");
        }

        public Car()
        {
            Make = "Fiat";
        }

        public Car(string make)
        {
            Make = make;
        }

        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

    }
}
