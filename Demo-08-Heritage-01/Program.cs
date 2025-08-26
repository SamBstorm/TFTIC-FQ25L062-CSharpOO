namespace Demo_08_Heritage_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chat a1 = new Chat()
            {
                BirthDate = new(2025, 8, 26),
                Nom = "Médor",
                Proprietaire = null,
                EtreCastre = true
            };

            do
            {
                Console.WriteLine(a1);
                a1.Vivre();
                if (a1.AvoirFaim)
                {
                    Console.WriteLine($"Voulez-vous nourrir {a1.Nom} ?");
                    bool nourrir = Console.ReadLine().ToLower() == "oui";
                    if (nourrir)
                    {
                        a1.Manger();
                    }
                    Console.ReadLine();
                }
            } while (true);
        }
    }
}
