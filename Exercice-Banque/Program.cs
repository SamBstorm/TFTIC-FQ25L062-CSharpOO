using Exercice_Banque.Models;
using System.Text;

namespace Exercice_Banque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercice 01
            Console.OutputEncoding = Encoding.Unicode;

            Personne p = new()
            {
                Nom = "Legrain",
                Prenom = "Samuel",
                DateNaiss = new(1987, 9, 27)
            };

            Courant c1 = new()
            {
                Numero = "BE01",
                Titulaire = p,
                LigneDeCredit = 50
            };

            c1.Depot(10_000);

            Console.WriteLine($"Infos compte \"{c1.Numero}\":\nTitulaire : {c1.Titulaire.Nom} {c1.Titulaire.Prenom}\nSolde : {c1.Solde} €\nLigne de crédit : {c1.LigneDeCredit} €");

            c1.Retrait(10_050);

            Console.WriteLine($"Infos compte \"{c1.Numero}\":\nTitulaire : {c1.Titulaire.Nom} {c1.Titulaire.Prenom}\nSolde : {c1.Solde} €\nLigne de crédit : {c1.LigneDeCredit} €");
            #endregion

            #region Exercice 02

            Banque b = new() { 
                Nom = "TFTIC"
            };

            b.Ajouter(c1);
            b.Ajouter(new()
            {
                Numero = "BE02",
                Titulaire = p,
                LigneDeCredit = 100
            });

            b.Ajouter(new()
            {
                Numero = "BE03",
                Titulaire = new()
                {
                    Nom = "Claes",
                    Prenom = "Alexandre",
                    DateNaiss = new(1991, 1, 1)
                },
                LigneDeCredit = 50
            });

            Console.WriteLine("Utilisateur, veuillez choisir un compte");
            string numeroChoisi = Console.ReadLine() ?? "";
            Courant? compteChoisi = b[numeroChoisi];
            if (compteChoisi is null)
            {
                Console.WriteLine($"Aucun compte ne correspond au numéro \"{numeroChoisi}\"...");
            }
            else {
                Console.WriteLine($"Infos compte \"{compteChoisi.Numero}\":\nTitulaire : {compteChoisi.Titulaire.Nom} {compteChoisi.Titulaire.Prenom}\nSolde : {compteChoisi.Solde} €\nLigne de crédit : {compteChoisi.LigneDeCredit} €");
            }

            #endregion

            #region Exercice 03

            b["BE02"]?.Depot(100);
            b["BE03"]?.Depot(100);
            Console.Clear();
            Console.WriteLine("Veuillez vous identifier :");
            Console.WriteLine("Nom :");
            string userName = Console.ReadLine();
            Console.WriteLine("Prénom :");
            string userFirstname = Console.ReadLine();
            Console.WriteLine("Date de naissance :");
            DateOnly userBirthdate = DateOnly.Parse(Console.ReadLine());

            Personne currentUser = new()
            {
                Nom = userName,
                Prenom = userFirstname,
                DateNaiss = new DateTime(userBirthdate, new TimeOnly())
            };

            Console.WriteLine("Voici vos avoirs :");
            Console.WriteLine($"{b.AvoirsDesComptes(currentUser)} €");

            #endregion
        }
    }
}
