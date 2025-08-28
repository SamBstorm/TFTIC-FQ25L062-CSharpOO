namespace Exercice_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dice.Minimum = 1;
            Dice.Maximum = 20;
            Console.WriteLine(Dice.Roll());

            Console.WriteLine($"Je lance 3 dés de {Dice.Minimum} à {Dice.Maximum} :");

            foreach (int result in Dice.Roll(3))
            {
                Console.WriteLine(result);
            }
        }
    }
}
