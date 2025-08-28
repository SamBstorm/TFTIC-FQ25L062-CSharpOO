using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_15_Interface_04
{
    [Flags]
    internal enum HeroesClasses
    {
        Mage = 1,
        Guerrier = 2,
        GuerrierMage = Mage + Guerrier,
        Soigneur = 4,
        Archimage = 5,
        Paladin = 6,
        Voleur = 8,
        Illusioniste = 9,
        Truand = 10,
        Samaritin = 12
    }
}
