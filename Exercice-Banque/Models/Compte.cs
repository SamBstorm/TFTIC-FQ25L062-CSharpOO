using Exercice_Banque.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Banque.Models
{
    internal abstract class Compte : IBanker
    {
        public string Numero { get; private set; }
        public Personne Titulaire { get; private set; }
        public double Solde { get; private set; }

        protected Compte(string numero, Personne titulaire) : this(numero, titulaire, default)
        {
        }

        protected Compte(string numero, Personne titulaire, double solde)
        {
            Numero = numero;
            Titulaire = titulaire;
            Solde = solde;
        }

        public void Depot(double montant)
        {
            if (montant <= 0) throw new ArgumentOutOfRangeException(nameof(montant),"Le montant à déposer doit être supérieur à 0.");
            Solde += montant;
        }

        protected void Retrait(double montant, double limite)
        {
            if (montant <= 0) throw new ArgumentOutOfRangeException(nameof(montant), "Le montant à retirer doit être supérieur à 0.");
            if (montant > Solde + limite) throw new SoldeInsuffisantException(this.Numero, this.Solde, montant, limite);
            Solde -= montant;
        }

        public virtual void Retrait(double montant) 
        {
            Retrait(montant, 0);
        }

        public void AppliquerInteret()
        {
            Solde += CalculerInteret();
        }

        protected abstract double CalculerInteret();

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
