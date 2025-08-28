using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_15_Interface_04
{
    internal class Guerrier : Personnage, IGuerrier
    {
        public void Hit(Personnage adversaire)
        {
            Console.WriteLine($"{Nom} frappe {adversaire.Nom} !");
            int degat = this.Attack - adversaire.Def;
            Console.WriteLine($"-{degat} dégats!");
            adversaire.SeBlesser(degat);
        }
    }
}
