using Demo_18_Exception.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_18_Exception.Models
{
    internal class Personne
    {

        public string Nom { get; private set; }
        public string Prenom { get; private set; }

        public DateOnly BirthDate { get; private set; }
        /// <summary>
        /// Permet de générer une instance de personne avec un nom et un prénom.
        /// </summary>
        /// <param name="nom">Correspond au nom de famille.</param>
        /// <param name="prenom">Correspond au prénom.</param>
        /// <exception cref="Exception"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        private Personne(string nom, string prenom)
        {
            if (nom is null) throw new Exception("Le nom ne peut pas être null");
            if (prenom is null) throw new ArgumentNullException(nameof(prenom), "Le prénom ne peut pas être null");
            Nom = nom;
            Prenom = prenom;
        }

        public Personne (string nom, string prenom, DateOnly birthDate)
        {
            if (nom is null) throw new ArgumentNullException(nameof(nom), "Le nom ne peut pas être null");
            if (prenom is null) throw new ArgumentNullException(nameof(prenom), "Le prénom ne peut pas être null");
            Nom = nom;
            Prenom = prenom;
            try
            {
                ExceptionValidators.CheckYearsOld(birthDate);
            }
            catch(Exception e)
            {
                throw new ArgumentOutOfRangeException(nameof(birthDate), e);
            }
            BirthDate = birthDate;
        }


    }
}
