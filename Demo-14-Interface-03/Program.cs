namespace Demo_14_Interface_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero h = new() { Nom = "Hugo" };
            Console.WriteLine("Veuillez choisir une classe :");

            Console.WriteLine("1 Efle");
            Console.WriteLine("2 Nain");
            Console.WriteLine("3 Voleur");

            string classeChoisie = Console.ReadLine();

            switch (classeChoisie)
            {
                case "1":
                    IElfe e = h;
                    e.TirerArc();
                    e.FairePotion();
                    break;
                case "2":
                    INain n = h;
                    n.FrapperHache();
                    n.RecolterMinerais();
                    break;
                case "3":
                    IVoleur v = h;
                    v.UtiliserDague();
                    v.Voler();
                    break;
            }
        }
    }
}
