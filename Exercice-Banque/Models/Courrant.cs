using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Banque.Models
{
    internal class Courrant
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

    }
}
