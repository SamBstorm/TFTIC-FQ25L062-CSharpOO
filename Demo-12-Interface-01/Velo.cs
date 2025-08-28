using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_12_Interface_01
{
    internal class Velo : IRoulable
    {
        private int _nbRoues = 2;
        public int NbRoues {
            get
            {
                return _nbRoues;
            }
            set
            { 
                if (value < 0) return;//Exception
                _nbRoues = value;
            }
        }

        public void Rouler(int distance)
        {
            Console.WriteLine($"Je roule {distance} km.");
        }
    }
}
