using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_08_Heritage_01
{
    internal class Chien: Animal
    {
        public bool AvoirPedigre { get; set; }

        public void Aboyer()
        {
            Crier();
        }

        protected override void Crier()
        {
            Console.WriteLine("Woof! Woof!");
        }

        public override string ToString()
        {
            return "Chien" + base.ToString();
        }
    }
}
