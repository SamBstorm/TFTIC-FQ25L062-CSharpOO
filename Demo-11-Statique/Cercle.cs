using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_11_Statique
{
    internal class Cercle
    {
        public static double PI = 3.141592;
        public double Rayon { get; set; }

        public double Perimetre()
        {
            return Rayon * 2 * PI;
        }

        public static double Perimetre(double rayon)
        {
            return rayon * 2 * PI;
        }
    }
}
