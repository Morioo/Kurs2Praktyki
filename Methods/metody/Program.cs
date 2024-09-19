using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintLogo();
            //PrintSign(20);

            /*
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());



            
            PrintMax(n, m);
            */


            
                //PrintNumbers(2, 9);
                    //PrintNumbers();
            //PrintNumbers(end: 20, start: -5);

                Console.Write("Ilośc elementów = ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];
            for     (int i = 0; i < size; i++)
            {   
                
                Console.Write("arr[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            bool allPositive = AreAllPositive(array);



            if (allPositive)
            {
                Console.WriteLine("Wszystkie liczby są dodatnie.");
            }

            else
            {
                Console.WriteLine("Nie wszytkie liczby są dodatnie.");
            }

        }

        static void PrintLogo()
        {


            Console.WriteLine("Kursy Videpoint");
            Console.WriteLine("Programowanie obiektowe");
        }

        static void PrintSign(int number)
        {


            if (number > 0)
            {
                Console.WriteLine($"Liczba {number} jest dodatnia");
            }

            else if (number < 0)
            {
                Console.WriteLine($"Liczba {number} jest ujemna");
            }

            else
            {
                Console.WriteLine($"Liczba {number} jest zerem");
            }

        }
        static void PrintMax(float number1, float number2)
        {
            float max = number1;
            if (number2 > number1)
                max = number2;
            Console.WriteLine($"Maximal number: {max}");
        }

        static void PrintNumbers(int start = 0, int end = 10)
        {
            for (int i = start; i < end; i++)
            {
                Console.WriteLine(i);
            }
        }

        static bool AreAllPositive(int[] seq)
        {
            foreach (int number in seq)
            {
                if (number <= 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
