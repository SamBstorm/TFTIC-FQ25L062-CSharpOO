using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Banque.Models
{
    internal class Compte
    {
        public string Numero { get; set; }
        public Personne Titulaire { get; set; }
        public double Solde { get; private set; }

        public void Depot(double montant)
        {
            if (montant <= 0) return; //A remplacer par une exception
            Solde += montant;
        }

        protected void Retrait(double montant, double limite)
        {
            if (montant <= 0) return; //Gestion par exception
            if (montant > Solde + limite) return; //Gestion par exception
            Solde -= montant;
        }

        public virtual void Retrait(double montant) 
        {
            Retrait(montant, 0);
        }

        public static double operator +(Compte left, Compte right)
        {
            /*double soldeLeft = 0;
            double soldeRight = 0;
            if (left.Solde > 0) soldeLeft = left.Solde;
            if (right.Solde > 0) soldeRight = right.Solde;
            return soldeLeft + soldeRight;*/
            return ((left.Solde > 0) ? left.Solde : 0) + ((right.Solde > 0) ? right.Solde : 0);
        }

        public static double operator +(double left, Compte right)
        {
            /*double soldeRight = 0;
            if (right.Solde > 0) soldeRight = right.Solde;
            return left + soldeRight;*/
            return left + ((right.Solde > 0) ? right.Solde : 0);
        }
    }
}
