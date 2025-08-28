using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_15_Interface_04
{
    internal class GuerrierMage : Guerrier, IMage
    {
        public void AttackMagic(Personnage adversaire)
        {
            Console.WriteLine($"{Nom} frappe {adversaire.Nom} !");
            int degat = this.SpellAttack - adversaire.SpellDef;
            Console.WriteLine($"-{degat} dégats!");
            adversaire.SeBlesser(degat);
        }
    }
}
