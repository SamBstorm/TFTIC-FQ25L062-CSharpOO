namespace Demo_16_Constructeur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personnage p = new Personnage("Arthur");

            Console.WriteLine($"Nom : {p.Nom}\nPV : {p.CurrentPV}/{p.PVMax}");

            Personnage p2 = new Personnage("Merlin",32,100);

            Console.WriteLine($"Nom : {p2.Nom}\nPV : {p2.CurrentPV}/{p2.PVMax}");

            Personnage p3 = new Guerrier("Salvatore", 40);

            Console.WriteLine($"Nom : {p3.Nom}\nPV : {p3.CurrentPV}/{p3.PVMax}");
            if(p3 is Guerrier g)
            {
                Console.WriteLine($"Force : {g.Force}\nDefense : {g.Defense}");
            }
        }
    }
}
