using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Static
{
    internal static class Dice
    {
        private static Random RNG = new();
        private static int _minimum = 1;
        private static int _maximum = 6;

        public static int Minimum
        {
            get { return _minimum; }
            set {
                _minimum = value;
                if (_maximum <= _minimum) _maximum = _minimum + 1;
            }
        }

        public static int Maximum
        {
            get { return _maximum; }
            set
            {
                _maximum = value;
                if (_minimum >= _maximum) _minimum = _maximum - 1;
            }
        }

        public static int Roll()
        {            
            return RNG.Next(Minimum, Maximum+1);
        }

        public static int[] Roll(int nb)
        {
            int[] rolls = new int[nb];
            for (int i = 0; i < nb; i++)
            {
                rolls[i] = Roll();
            }
            return rolls;
        }
    }
}
