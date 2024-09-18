using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Document : IStorable, ISpeak
    {
        public double DurationOfSpeach
        {
            get
            {
                return 42;
            }
        }






        public void Read(string path)
        {


            Console.WriteLine($"Reading from {path}");

        }




        public void Speak()
        {
            Console.WriteLine("Speaking");
        }




        public void Write(string path)
        {
            Console.WriteLine($"Writing to {path}");
        }

    }
}
