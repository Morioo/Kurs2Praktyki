using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    class Log
    {
        public void Subscribe(Clock theClock)
        {
            theClock.SecondChanged += LogTime;
        }


        public void LogTime(object o, TimeInfo e)



        {
            Console.WriteLine("Logging");
        }
    }
}
