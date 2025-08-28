using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_12_Interface_01
{
    internal class Personne
    {
        public IRoulable MoyenLocomotion { get; set; }

        public void SeDeplacer(int originX, int originY, int destinationX, int destinationY)
        {
            if (MoyenLocomotion is null) return; //Exception
            int dist = (int)Math.Sqrt(
                Math.Pow(Math.Abs(originX - destinationX), 2)
                +
                Math.Pow(Math.Abs(originY - destinationY), 2)
                );
            MoyenLocomotion.Rouler(dist);
        }
    }
}
