using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_20_Delegate_02.Models
{
    internal class VSCodeExtension
    {
        public string Name { get; private set; }

        public VSCodeExtension(string name)
        {
            Name = name;
        }

        public void Init()
        {
            Console.WriteLine($"Démarrage de {Name}...");
        }

        public void Arret()
        {
            Console.WriteLine($"Arrêt de {Name}...");
        }
    }
}
