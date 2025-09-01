using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_24_Evenement_01.Models
{
    delegate void ActionArbre();
    internal class Arbre
    {
        public event ActionArbre chute;
        public bool EstDebout { get; private set; }

        public Arbre()
        {
            EstDebout = true;
        }

        public void Tomber()
        {
            if (EstDebout)
            {
                EstDebout = false;
                chute?.Invoke();
            }
        }
    }
}
