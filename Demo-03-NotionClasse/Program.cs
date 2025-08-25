namespace Demo_03_NotionClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture laFerrari = new Voiture()
            {
                couleur = "Rouge",
                immatriculation = "1-ABC-123",
                nbRoues = 4
            };

            Console.WriteLine($"Voici ma petite twingo, elle est {laFerrari.couleur}, immatriculée {laFerrari.immatriculation}, avec ses {laFerrari.nbRoues} roues.");

            Console.WriteLine("Je la présente à ma mère, qui l'appelle la fraise!");

            Voiture laFraise = laFerrari;

            Console.WriteLine("En colère, je pars avec et me crash...");
            laFerrari.nbRoues--;

            Console.WriteLine($"Après l'accident, elle est {laFerrari.couleur}, immatriculée {laFerrari.immatriculation}, avec ses {laFerrari.nbRoues} roues.");


            Console.WriteLine($"Après l'accident, elle est {laFraise.couleur}, immatriculée {laFraise.immatriculation}, avec ses {laFraise.nbRoues} roues.");

        }
    }
}
