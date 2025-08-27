using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_11_Statique
{
    internal static class ConsoleAvancee
    {
        public static void WriteLineRainbow(string text)
        {
            int i = 0;
            foreach (char caractere in text.ToCharArray())
            {
                Console.BackgroundColor = (ConsoleColor)(i%16);
                Console.ForegroundColor = (ConsoleColor)(15-(i%16));
                Console.Write(caractere);
                i++;
            }
            Console.WriteLine();
        }
    }
}
