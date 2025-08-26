namespace Demo_06_Indexeurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck d = new();
            d.SetNewDeck();
            Card pioche = d[42];

            Console.WriteLine($"J'ai pioché le {pioche.Value} de {pioche.Color}!");

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(d.ListCards());

            Console.ReadLine();
            Console.WriteLine("Je replace cette carte en dernière position");
            d[51] = pioche;

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(d.ListCards());

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Je veux récupérer l'As de Pique...");

            Card? carteRecherchee = d[Colors.Pique, CardValues.As];

            if(carteRecherchee is null)
            {
                Console.WriteLine("Elle n'est pas dans le paquet");
            }
            else
            {
                Console.WriteLine($"La voici!\n{carteRecherchee.Value} de {carteRecherchee.Color}");
            }
        }
    }
}
