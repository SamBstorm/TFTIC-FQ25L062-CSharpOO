using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_13_Interface_02
{
    internal class ConsoleVerticale : IConsole
    {
        private int _col = 0;

        public void Write(string text)
        {
            foreach (char caractere in text)
            {
                Console.WriteLine(caractere);
            }
        }

        public void WriteLine(string text)
        {
            Write(text);
            WriteLine();
        }

        public void WriteLine()
        {
            _col++;
            Console.SetCursorPosition(_col, 0);
        }
    }
}
