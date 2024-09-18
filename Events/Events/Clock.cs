using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Events
{
    class Clock


    {
        public delegate void SecondChangedHandler(object clock,


            TimeInfo timeInfo);


        public event SecondChangedHandler SecondChanged;
        
        public void Run ()
        {
            do



            {
                Thread.Sleep(1000);
                
                
                
                DateTime now = DateTime.Now;
                
                
                TimeInfo timeInfo = new TimeInfo(now.Hour, now.Minute, now.Second);

                SecondChanged(this, timeInfo);

            } while (true);
        }
    }
}
