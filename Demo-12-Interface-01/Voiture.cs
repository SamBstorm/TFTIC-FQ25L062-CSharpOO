using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_12_Interface_01
{
    internal class Voiture : IRoulable, IImmatriculable
    {
        private int _nbRoues = 4;
        public int NbRoues { 
            get {
                return _nbRoues;
            } 
            set
            {
                if (value <= 2) return;//Exception
                _nbRoues = value;
            }
        }

        public string Immatriculation { get; set; }

        public double Kilometrage { get; private set; } = 0;

        public void Rouler(int distance)
        {
            Kilometrage += distance;
            Console.WriteLine("Mon kilométrage est à " + Kilometrage + "km.");
        }
    }
}
