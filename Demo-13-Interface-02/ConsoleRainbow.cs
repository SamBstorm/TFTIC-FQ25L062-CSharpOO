using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_13_Interface_02
{
    internal class ConsoleRainbow : IConsole
    {
        public void Write(string text)
        {
            int i = 0;
            foreach (char caractere in text)
            {
                Console.BackgroundColor = (ConsoleColor)(i % 16);
                Console.ForegroundColor = (ConsoleColor)(15-(i % 16));
                Console.Write(caractere);
                i++;
                Console.ResetColor();
            }
        }

        public void WriteLine(string text)
        {
            Write(text);
            WriteLine();
        }

        public void WriteLine()
        {
            Console.WriteLine();
        }
    }
}
