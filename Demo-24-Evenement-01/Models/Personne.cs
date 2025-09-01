using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_24_Evenement_01.Models
{
    public delegate void ActionPersonne(object sender, Personne receiver);
    public class Personne
    {
        public bool EstBlesse { get; private set; }
        public event ActionPersonne blesseEvent;

        public void SeBlesser(object agresseur)
        {
            blesseEvent?.Invoke(agresseur, this);
        }
    }
}
