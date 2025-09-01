using Exercice_CarWash.Models;

namespace Exercice_CarWash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture v1 = new("1-ABC-123");
            Voiture v2 = new("2-DEF-456");
            Voiture v3 = new("0-GHI-789");

            CarWash cw = new();

            cw.Traiter(v1);
            cw.Traiter(v2);
            cw.Traiter(v3);
        }
    }
}
