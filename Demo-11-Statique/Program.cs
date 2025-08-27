namespace Demo_11_Statique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parametres.BackgroundColor = ConsoleColor.Red;

            Console.ForegroundColor = Parametres.FontColor;
            Console.BackgroundColor = Parametres.BackgroundColor;


            Cercle.PI = 5;
            //Cercle c1 = new Cercle()
            //{
            //    Rayon = 2.5
            //};
            //Console.WriteLine($"Le périmètre d'un cercle de rayon {c1.Rayon} est de {c1.Perimetre()}");
            //Cercle c2 = new Cercle()
            //{
            //    Rayon = 9.75
            //};
            //Console.WriteLine($"Le périmètre d'un cercle de rayon {c2.Rayon} est de {c2.Perimetre()}");
            //Cercle c3 = new Cercle()
            //{
            //    Rayon = 9.75
            //};
            //Console.WriteLine($"Le périmètre d'un cercle de rayon {c3.Rayon} est de {c3.Perimetre()}");
            ConsoleAvancee.WriteLineRainbow($"Le périmètre d'un cercle de rayon 2.5 est de {Cercle.Perimetre(2.5)}");

        }
    }
}
