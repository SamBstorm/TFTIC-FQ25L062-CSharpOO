using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_27_Generic_02.Models
{
    internal class Boite<T>
    {
        public T Contenu { get; set; }

        public Boite(T contenu)
        {
            Contenu = contenu;
        }

        public void Afficher() {
            Console.WriteLine($"La boite contient : {Contenu}");
        }

        public void Remplacer(T nouveauContenu)
        {
            Contenu = nouveauContenu;
        }
    }
}
