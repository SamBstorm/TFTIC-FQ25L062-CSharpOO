using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_15_Interface_04
{
    internal class Archimage : Mage, ISoigneur
    {
        public void Soigner(Personnage blesse)
        {
            Console.WriteLine($"{Nom} soigne {blesse.Nom} !");
            int soin = SpellAttack + Def;
            Console.WriteLine($"+{soin} PV!");
            blesse.AvoirSoin(soin);
        }
    }
}
