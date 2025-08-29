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

                Personne p = new("Legrain","Samuel",new(1987, 9, 27));

                Courant c1 = new("BE01",p,50,10_000);

                Console.WriteLine($"Infos compte \"{c1.Numero}\":\nTitulaire : {c1.Titulaire.Nom} {c1.Titulaire.Prenom}\nSolde : {c1.Solde} €\nLigne de crédit : {c1.LigneDeCredit} €");

                c1.Retrait(10_500);

                Console.WriteLine($"Infos compte \"{c1.Numero}\":\nTitulaire : {c1.Titulaire.Nom} {c1.Titulaire.Prenom}\nSolde : {c1.Solde} €\nLigne de crédit : {c1.LigneDeCredit} €");
                #endregion

                #region Exercice 02

                Banque b = new() { 
                    Nom = "TFTIC"
                };

                b.Ajouter(c1);
                Courant c2 = new("BE02",p,100);
                b.Ajouter(c2);

                b.Ajouter(
                    new Courant(
                        "BE03",
                        new("Claes","Alexandre",new(1991, 1, 1)),
                        50
                    )
                );

                b.Ajouter(
                    new Epargne(
                        "BE04",
                        new("Claes","Alexandre",new(1991, 1, 1))
                    )
                );

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

                Personne currentUser = new(
                    userName,
                    userFirstname,
                    new DateTime(userBirthdate, new TimeOnly())
                );

                Console.WriteLine("Voici vos avoirs :");
                Console.WriteLine($"{b.AvoirsDesComptes(currentUser)} €");

            #endregion
            #region Exercice 6
            IBanker compteAvecInteret = b["BE01"];
            Console.WriteLine($"Le solde actuel de {compteAvecInteret.Numero} est de {compteAvecInteret.Solde} €");
            compteAvecInteret.AppliquerInteret();
            Console.WriteLine($"Le solde de {compteAvecInteret.Numero} après application des intérêts est de {compteAvecInteret.Solde} €");
            compteAvecInteret = b["BE04"];
            Console.WriteLine($"Le solde actuel de {compteAvecInteret.Numero} est de {compteAvecInteret.Solde} €");
            compteAvecInteret.AppliquerInteret();
            Console.WriteLine($"Le solde de {compteAvecInteret.Numero} après application des intérêts est de {compteAvecInteret.Solde} €");
            compteAvecInteret = b["BE03"];
            Console.WriteLine($"Le solde actuel de {compteAvecInteret.Numero} est de {compteAvecInteret.Solde} €");
            compteAvecInteret.AppliquerInteret();
            Console.WriteLine($"Le solde de {compteAvecInteret.Numero} après application des intérêts est de {compteAvecInteret.Solde} €");

            #endregion

            #region Exercice 07

            ICustomer compteClient = b["BE01"];

            Console.WriteLine($"Le solde du compte BE01 est de {compteClient.Solde} €");
            Console.WriteLine("Combien pour votre dépôt ?");
            double montant = double.Parse(Console.ReadLine());
            compteClient.Depot(montant);
            Console.WriteLine($"Le solde du compte BE01 est de {compteClient.Solde} €");


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
