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
                if (value < 0) throw new InvalidOperationException("La ligne de crédit doit être positif.");
                _ligneDeCredit = value;
            }
        }
        public Courant(string numero, Personne titulaire, double ligneDeCredit) : this (numero, titulaire, ligneDeCredit, default)
        {
        }
        public Courant(string numero, Personne titulaire, double ligneDeCredit, double solde) : base(numero, titulaire, solde)
        {
            LigneDeCredit = ligneDeCredit;
        }

        public override void Retrait(double montant)
        {
            base.Retrait(montant, LigneDeCredit);

            if(Solde < 0)
            {
                // PassageEnNegatif.Invoke(); Ne fonctionne pas :(
                // on passe par une méthode du parant pour appeler l'event
                TriggerPassageEnNegatif();
            }
        }

        protected override double CalculerInteret()
        {
            return (Solde >= 0) ? (Solde * 0.03) : (Solde * 0.0975);
            //return Solde * ((Solde >= 0) ? 0.03 : 0.0975);
        }
    }
}
