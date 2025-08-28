using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_13_Interface_02
{
    internal interface IConsole
    {
        void WriteLine(string text);
        void WriteLine();
        void Write(string text);
    }
}
