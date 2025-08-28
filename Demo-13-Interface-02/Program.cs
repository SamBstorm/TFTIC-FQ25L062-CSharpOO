namespace Demo_13_Interface_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IConsole console = new ConsoleRainbow();

            console.WriteLine("Voici un texte arc-en-ciel!");

            Console.ReadLine();

            Console.Clear();
            console = new ConsoleVerticale();
            console.WriteLine("Voici un texte à la verticale!");

        }
    }
}
