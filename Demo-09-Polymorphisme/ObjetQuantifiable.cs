using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_09_Polymorphisme
{
    internal class ObjetQuantifiable : ObjetInventaire
    {
        private int _quantite;
        public int Quantite
        {
            get { return _quantite; }
            set
            {
                if (value < 0) return; //Exception
                _quantite = value;
            }
        }
        public void Jeter(int nbAJeter)
        {
            if (nbAJeter > Quantite) return; //Exception
            Quantite -= nbAJeter;
        }
    }
}
