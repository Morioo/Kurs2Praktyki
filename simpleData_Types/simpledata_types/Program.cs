using System;

namespace SimpleDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            */
            //C = 5/9*(F-32)





            double C = double.NegativeInfinity;
            double F = double.NegativeInfinity;

                Console.WriteLine("Podaj temperaturę w stopniach Fahrenhaita");

            F = double.Parse(Console.ReadLine());

                C = 5d / 9 * (F - 32);
            Console.WriteLine(C);
        }
    }
}
