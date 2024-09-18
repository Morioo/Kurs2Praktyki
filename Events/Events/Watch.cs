using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    class Watch
    {
        public void Subscribe(Clock theClock)
        {
            theClock.SecondChanged += NewTime;
        }

        public void NewTime(object o, TimeInfo e)
        {

            Console.WriteLine($"Biezący czas: {e.Hour.ToString()}" +
                $"{e.Minute.ToString()} ,{e.Second.ToString()}");
        }











    }
}
