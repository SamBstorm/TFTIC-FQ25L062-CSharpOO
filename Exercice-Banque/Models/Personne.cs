using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Banque.Models
{
    internal class Personne
    {

        public string Nom { get; private set; }
        public string Prenom { get; private set; }
        public DateTime DateNaiss { get; private set; }
        public Personne(string nom, string prenom, DateTime dateNaiss)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaiss = dateNaiss;
        }

        public static bool operator == (Personne left, Personne right)
        {
            return (left.Nom == right.Nom) 
                && (left.Prenom == right.Prenom) 
                && (left.DateNaiss == right.DateNaiss);
        }

        public static bool operator != (Personne left, Personne right)
        {
            return !(left == right);
        }
    }
}
