using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_14_Interface_03
{
    internal class Hero : IElfe, INain, IVoleur
    {
        public string Nom { get; set; }
        public int Niveau { get; set; }

        public void TirerArc()
        {
            Console.WriteLine("Je tire une flèche!");
        }

        public void FairePotion()
        {
            Console.WriteLine("Je me demande ce que fais cette potion!");
        }

        public void FrapperHache()
        {
            Console.WriteLine("Je fais de gros dégat!");
        }

        public void RecolterMinerais()
        {
            Console.WriteLine("Wahou! Une pépite!");
        }

        public void UtiliserDague()
        {
            Console.WriteLine("Je fais de petit dégat!");
        }

        public void Voler()
        {
            Console.WriteLine("Je vole!");
        }

        public void SeSoigner()
        {
            /* Non fonctionnel car notre instance Hero est aussi bien de type IElfe et IVoleur
            if(this is IElfe)
            {
                Console.WriteLine("Je me soigne grâce à la nature!");
            }
            else if(this is IVoleur)
            {
                Console.WriteLine("J'utilise les bandages que j'ai volé!");
            }*/
            Console.WriteLine("Je me soigne!");
        }
    }
}
