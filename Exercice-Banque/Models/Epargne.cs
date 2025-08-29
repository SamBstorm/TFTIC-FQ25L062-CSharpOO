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
        public Epargne(string numero, Personne titulaire) : this(numero, titulaire, default, default)
        {
        }

        public Epargne(string numero, Personne titulaire, double solde, DateTime? dateDernierRetrait) : base(numero, titulaire, solde)
        {
            DateDernierRetrait = dateDernierRetrait;
        }

        public override void Retrait (double montant)
        {
            double oldSolde = Solde;
            base.Retrait(montant);
            if(Solde != oldSolde) DateDernierRetrait = DateTime.Now;
        }

        protected override double CalculerInteret()
        {
            return Solde * 0.045;
        }
    }
}
