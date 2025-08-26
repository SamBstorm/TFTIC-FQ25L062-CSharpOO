namespace Demo_07_Operateurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Panier p1 = new();

            p1.Ajouter(new());
            p1.Ajouter(new());
            p1.Ajouter(new());

            Panier p2 = new();
            p2.Ajouter(new());
            p2.Ajouter(new());
            p2.Ajouter(new());
            p2.Ajouter(new());

            Console.WriteLine($"Dans mon panier, j'ai actuellement {p1.Count} fruits.");

            Console.WriteLine($"Dans le panier de mon collègue, il a actuellement {p2.Count} fruits.");

            Panier recolteTotal = p1 + p2;

            Console.WriteLine($"Au total, nous avons récolté : {recolteTotal.Count} fruits!");

            Console.WriteLine("Voici un nouveau fruit!");

            //p1 = p1 + new Fruit();
            p1 += new Fruit(); 
            Console.WriteLine($"Dans mon panier, j'ai actuellement {p1.Count} fruits.");

            if (p1 == p2)
            {
                Console.WriteLine("Nous avons le même nombre de fruits!");
            }
            else {
                Console.WriteLine("Nous n'avons pas la même récolte...");
            }
        }
    }
}
