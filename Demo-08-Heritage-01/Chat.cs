using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_08_Heritage_01
{
    internal class Chat : Animal
    {
        public bool EtreCastre { get; set; }
        public void Miauler()
        {
            Crier();
        }

        protected override void Crier()
        {
            Console.WriteLine("Miaou!");
        }

        public override string ToString()
        {
            return "Chat" + base.ToString();
        }
    }
}
