using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Banque.Models.Exceptions
{
    internal class SoldeInsuffisantException : Exception
    {
        public string NumeroCompte { get; private set; }
        public double SoldeActuel { get; private set; }
        public double MontantRetrait { get; private set; }
        public double LimiteSolde { get; private set; }

        public SoldeInsuffisantException(string numeroCompte, double soldeActuel, double montantRetrait, double limiteSolde) : base("Le solde de votre compte ne permet pas d'effectuer le retrait d'un tel montant.")
        {
            NumeroCompte = numeroCompte;
            SoldeActuel = soldeActuel;
            MontantRetrait = montantRetrait;
            LimiteSolde = limiteSolde;
        }

        public SoldeInsuffisantException(string message, string numeroCompte, double soldeActuel, double montantRetrait, double limiteSolde) : base(message)
        {
            NumeroCompte = numeroCompte;
            SoldeActuel = soldeActuel;
            MontantRetrait = montantRetrait;
            LimiteSolde = limiteSolde;
        }
    }
}
