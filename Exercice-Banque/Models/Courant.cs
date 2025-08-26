using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Banque.Models
{
    internal class Courant
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
        public string Numero { get; set; }

        public Personne Titulaire { get; set; }

        public double Solde { get; private set; }

        public void Depot(double montant) {
            if (montant <= 0) return; //A remplacer par une exception
            Solde += montant;
        }
        public void Retrait(double montant)
        {
            if (montant <= 0) return; //A remplacer par une exception
            if (Solde - montant < -LigneDeCredit) return; //A remplacer par une exception
            Solde -= montant;
        }

        public static double operator +(Courant left, Courant right) {
            /*double soldeLeft = 0;
            double soldeRight = 0;
            if (left.Solde > 0) soldeLeft = left.Solde;
            if (right.Solde > 0) soldeRight = right.Solde;
            return soldeLeft + soldeRight;*/
            return ((left.Solde > 0) ? left.Solde : 0) + ((right.Solde > 0) ? right.Solde : 0);
        }

        public static double operator +(double left, Courant right)
        {
            /*double soldeRight = 0;
            if (right.Solde > 0) soldeRight = right.Solde;
            return left + soldeRight;*/
            return left + ((right.Solde > 0) ? right.Solde : 0);
        }
    }
}
