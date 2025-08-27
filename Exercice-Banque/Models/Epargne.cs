using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Banque.Models
{
    internal class Epargne : Compte
    {
        public DateTime? DateDernierRetrait { get; private set; }

        public override void Retrait (double montant)
        {
            double oldSolde = Solde;
            base.Retrait(montant);
            if(Solde != oldSolde) DateDernierRetrait = DateTime.Now;
        }
    }
}
