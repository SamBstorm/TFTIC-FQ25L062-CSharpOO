using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_10_Abstract
{
    internal abstract class Animal
    {
        public string Nom { get; set; }
        public abstract void Crier();

        /*A comparer avec les interfaces (voir chapitre suivant), on peut donner une valeur, et une encapsulation autre que public */
        protected DateOnly _dateArrivee = new DateOnly(2001,01,01);
    }
}
