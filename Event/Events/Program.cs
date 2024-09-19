using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            Watch watch = new Watch();
            watch.Subscribe(clock);

            Log log = new Log();
            log.Subscribe(clock);
            clock.Run();
        }

    }
}
