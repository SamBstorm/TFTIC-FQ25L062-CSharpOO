namespace Demo_15_Interface_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Utilisation des enums Flags
            //HeroesClasses classes = (HeroesClasses)((int)HeroesClasses.Soigneur + (int)HeroesClasses.Mage);

            //classes = HeroesClasses.Soigneur | HeroesClasses.Guerrier;

            //if (classes.HasFlag(HeroesClasses.Soigneur))
            //{
            //    Console.WriteLine("Il peut soigner");
            //}
            //if (classes.HasFlag(HeroesClasses.Guerrier))
            //{
            //    Console.WriteLine("Il peut frapper!");
            //} 
            #endregion

            Personnage hero;

            Console.WriteLine("Veuillez choisir deux classes entre :");
            Console.WriteLine("1. Guerrier");
            Console.WriteLine("2. Mage");
            Console.WriteLine("3. Soigneur");

            string classe1 = Console.ReadLine();


            Console.WriteLine("Veuillez choisir une seconde classe entre :");
            Console.WriteLine("1. Guerrier");
            Console.WriteLine("2. Mage");
            Console.WriteLine("3. Soigneur");

            string classe2 = Console.ReadLine();

            if(classe1 == "1")
            {
                if(classe2 == "2")
                {
                    hero = new GuerrierMage();
                }
                else
                {
                    hero = new Paladin();
                }
            }
            else if (classe1 == "2"){
                if (classe2 == "1") {
                    hero = new GuerrierMage();
                }
                else
                {
                    hero = new Archimage();
                }
            }
            else
            {
                if (classe2 == "1")
                {
                    hero = new Paladin();
                }
                else
                {
                    hero = new Archimage();
                }
            }


            if(hero is IMage mage)
            {
                Console.WriteLine("Il peut utiliser sa magie.");
            }
            if(hero is ISoigneur soigneur)
            {
                Console.WriteLine("Il peut se soigner, ainsi que ses alliés!");
                soigneur.Soigner(hero);
            }
            if(hero is IGuerrier guerrier)
            {
                Console.WriteLine("Il peut infliger de lourds dégats!");
                guerrier.Hit(hero);
            }
        }
    }
}
