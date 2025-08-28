using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_16_Constructeur
{
    internal class Guerrier : Personnage
    {
        public int Force { get; private set; }
        public int Defense { get; private set; }

        public Guerrier(string nom) : this(nom,20)
        {
        }

        public Guerrier(string nom, int pv) : base(nom, pv)
        {
            Force = 50;
            Defense = 20;
        }
    }
}
