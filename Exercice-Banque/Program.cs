using Exercice_Banque.Models;
using System.Text;

namespace Exercice_Banque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercice 01 + 02 + 03
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
                Courant c2 = new()
                {
                    Numero = "BE02",
                    Titulaire = p,
                    LigneDeCredit = 100
                };
                b.Ajouter(c2);

                b.Ajouter(new Courant()
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

                b.Ajouter(new Epargne()
                {
                    Numero = "BE04",
                    Titulaire = new()
                    {
                        Nom = "Claes",
                        Prenom = "Alexandre",
                        DateNaiss = new(1991, 1, 1)
                    }
                });

                Console.WriteLine("Utilisateur, veuillez choisir un compte");
                string numeroChoisi = Console.ReadLine() ?? "";
                Compte? compteChoisi = b[numeroChoisi];
                if (compteChoisi is null)
                {
                    Console.WriteLine($"Aucun compte ne correspond au numéro \"{numeroChoisi}\"...");
                }
                else if(compteChoisi is Courant courant){
                    Console.WriteLine($"Infos compte \"{courant.Numero}\":\nTitulaire : {courant.Titulaire.Nom} {courant.Titulaire.Prenom}\nSolde : {courant.Solde} €\nLigne de crédit : {courant.LigneDeCredit} €");
                }
                else if(compteChoisi is Epargne epargne)
                {
                    Console.WriteLine($"Infos compte \"{epargne.Numero}\":\nTitulaire : {epargne.Titulaire.Nom} {epargne.Titulaire.Prenom}\nSolde : {epargne.Solde} €\nDate dernier retrait : {epargne.DateDernierRetrait}");
                }

                #endregion

                #region Exercice 03

                b["BE02"]?.Depot(100);
                b["BE03"]?.Depot(100);
                b["BE04"]?.Depot(500);
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
            #endregion

            #region Exercice 04
            /*
            Courant c1 = new()
            {
                Numero = "BE01",
                Titulaire = new()
                {
                    Nom = "Legrain",
                    Prenom = "Samuel",
                    DateNaiss = new(1987, 9, 27)
                },
                LigneDeCredit = 50
            };

            Epargne e1 = new()
            {
                Numero = "BE02",
                Titulaire = new()
                {
                    Nom = "Legrain",
                    Prenom = "Samuel",
                    DateNaiss = new(1987, 9, 27)
                }
            };

            c1.Depot(10_000);

            e1.Depot(10_000);

            c1.Retrait(50_000);

            e1.Retrait(50_000);

            //Même la class Compte fonctionne!
            //Elle n'a que les comportements communs à Courant et Epargne,
            //Mais n'a pas les qualités des ses enfants (LigneDeCredit, DateDernierRetrait)
            Compte c0 = new()
            {
                Numero = "BE00",
                Titulaire = new()
                {
                    Nom = "Legrain",
                    Prenom = "Samuel",
                    DateNaiss = new(1987, 9, 27)
                }
            };

            c0.Depot(10_000);
            c0.Retrait(5_000);
            */
            #endregion

        }
    }
}
