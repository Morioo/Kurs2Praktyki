using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IStorable
    {

        void Write(string path);

        void Read(string path);
    }
}
