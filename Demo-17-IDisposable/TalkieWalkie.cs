using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Demo_17_IDisposable
{
    internal class TalkieWalkie : IDisposable
    {
        public string Nom { get; private set; }
        public TalkieWalkie(string nom)
        {
            Nom = nom;
            Console.WriteLine($"{Nom} est connectée.");
        }

        public void Parler(string text) {
            Console.WriteLine($"{Nom} {DateTime.Now.ToShortTimeString()} : {text}");
            Console.WriteLine("À vous!");
        }

        public void Dispose() {
            Console.WriteLine($"{Nom} {DateTime.Now.ToShortTimeString()} : Terminé!");
            Console.WriteLine($"{Nom} n'est plus en ligne...");
        }
    }
}
