using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_24_Evenement_01.Models
{

    delegate void ActionBucheron();
    internal class Bucheron : Personne
    {
        public event ActionBucheron frappeEvent;

        public void Frapper()
        {
            frappeEvent?.Invoke();
        }

    }
}
