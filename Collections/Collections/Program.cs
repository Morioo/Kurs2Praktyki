using System;
using System.Collections;
using System.Collections.Generic;



namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {




            Car car1 = new Car();
            car1.VIN = "abc123";
            car1.Make = "Mazda";




            Car car2 = new Car();
            car2.VIN = "bcd444";
            car2.Make = "Fiat";




            Book b1 = new Book();

            b1.Title = "C#";

            Car car3 = new Car() { VIN = "dge888", Make = "Skoda" };

            ArrayList myArrayList = new ArrayList();

            myArrayList.Add(car1);

            myArrayList.Add(car2);

            myArrayList.Add(car3);

            myArrayList.Add(b1);
            myArrayList.Remove(b1);


            foreach (Car item in myArrayList)
            {
                Console.WriteLine(item.Make);
            }

            //List<T>
            List<Car> myList = new List<Car>();

            myList.Add(car1);
            myList.Add(car2);

            //myList.Add(b1);

            List<Car> myCars = new List<Car>()

            {
                new Car {VIN = "a", Make = "Mazda"},

                new Car {VIN = "b"}

            };

        }
    }

    class Car

    {


        public string VIN { get; set; }

        public string Make { get; set; }
    }

    class Book

    {


        public string Title { get; set; }
    }
}
