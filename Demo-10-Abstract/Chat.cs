using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_10_Abstract
{
    internal class Chat : Animal
    {
        public override void Crier()
        {
            Console.WriteLine("Miaou!");
        }
    }
}
