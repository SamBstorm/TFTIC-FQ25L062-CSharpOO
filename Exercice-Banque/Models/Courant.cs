using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Banque.Models
{
    internal class Courant : Compte
    {
        private double _ligneDeCredit;
        public double LigneDeCredit
        {
            get { return _ligneDeCredit; }
            set {
                if (value < 0) return; //A remplacer par une exception
                _ligneDeCredit = value;
            }
        }

        public override void Retrait(double montant)
        {
            base.Retrait(montant, LigneDeCredit);
        }
        
    }
}
