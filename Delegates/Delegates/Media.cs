using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{





    class Media
    {
        public delegate bool TestMedia();



        public void Test (TestMedia mediaDelegate)
        {

            if (mediaDelegate() == true)
                Console.WriteLine("OK!");

            else

                Console.WriteLine("KO!");
        }
    }
}
