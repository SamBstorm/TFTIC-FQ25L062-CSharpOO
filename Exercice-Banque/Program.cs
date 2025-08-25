using Exercice_Banque.Models;
using System.Text;

namespace Exercice_Banque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Personne p = new()
            {
                Nom = "Legrain",
                Prenom = "Samuel",
                DateNaiss = new(1987, 9, 27)
            };

            Courrant c1 = new() { 
                Numero = "BE01",
                Titulaire = p,
                LigneDeCredit = 50
            };

            c1.Depot(10_000);

            Console.WriteLine($"Infos compte \"{c1.Numero}\":\nTitulaire : {c1.Titulaire.Nom} {c1.Titulaire.Prenom}\nSolde : {c1.Solde} €\nLigne de crédit : {c1.LigneDeCredit} €");

            c1.Retrait(10_050);

            Console.WriteLine($"Infos compte \"{c1.Numero}\":\nTitulaire : {c1.Titulaire.Nom} {c1.Titulaire.Prenom}\nSolde : {c1.Solde} €\nLigne de crédit : {c1.LigneDeCredit} €");
        }
    }
}
