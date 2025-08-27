using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_09_Polymorphisme
{
    internal class ObjetEquipement : ObjetQuantifiable
    {
        
        public bool EstEquipe { get; set; } = false;

        public void Equiper()
        {
            if (!EstEquipe)
            {
                Console.WriteLine("Je suis equipé!");
            }
            else
            {
                Console.WriteLine("Je suis déséquipé...");
            }
            EstEquipe = !EstEquipe;
        }
    }
}
