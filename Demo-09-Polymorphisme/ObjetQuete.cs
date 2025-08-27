using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_09_Polymorphisme
{
    internal class ObjetQuete : ObjetInventaire
    {
        public void Utiliser()
        {
            Console.WriteLine("Je fais mon office!");
        }
    }
}
