using System;
using System.Text;

namespace ControlStatements
{
    class Program
    {
        static void Main(string[] args)
        {




            /*
            int digit;

            int.TryParse(Console.ReadLine(), out digit);

            switch (digit)
            {
                case 0:
                    Console.WriteLine("liczba = 0");
                    break;
                case 1:
                    Console.WriteLine("Liczba =1");
                    break;
                default:
                    Console.WriteLine("inna liczba");
                    break;
            }

            
            string myString = "To jest kurs programowania obiektowego";
            Console.WriteLine(myString.ToUpper());
            

            StringBuilder myString = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }
            Console.WriteLine(myString);

            */

            int myLittleHorses = 0;


            do
            {

                Console.WriteLine($"bieżąca wartość to: {myLittleHorses}");

                myLittleHorses++;

            } while (myLittleHorses < 0);

        }
    }
}
