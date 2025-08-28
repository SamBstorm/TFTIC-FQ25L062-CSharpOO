using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_16_Constructeur
{
    internal class Personnage
    {
        public string Nom { get; private set; }
        public int CurrentPV { get; private set; }
        public int PVMax { get; private set; }

        public Personnage(string nom) : this(nom,20)
        {
        }

        public Personnage(string nom, int pv) : this(nom, pv, pv)
        {
        }

        public Personnage(string nom, int currentPV, int pVMax)
        {
            Nom = nom;
            CurrentPV = currentPV;
            PVMax = pVMax;
        }
    }
}
