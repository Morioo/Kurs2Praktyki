using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class RecordPlayer
    {
        private bool status;

        public bool Play()
        {
            Console.WriteLine("Playing record. OK");
            status = true;
            return status;
        }
    }
}
