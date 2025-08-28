using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_15_Interface_04
{
    internal abstract class Personnage : IPersonnage
    {
        public string Nom { get; set; }
        private int _currentPV;
        public int CurrentPV {
            get { return _currentPV; }
            set { 
                if (value <= 0) value = 0;
                if (value > PVMax) value = PVMax;
                _currentPV = value;
                if (_currentPV == 0) Mourir();
            }
        }

        private int _PVMax;
        public int PVMax { 
            get { return _PVMax; }
            set {
                if (value > 0 && value > _PVMax) _PVMax = value;
            } 
        }

        public int Attack { get; set; }

        public int SpellAttack { get; set; }

        public int Def { get; set; }

        public int SpellDef { get; set; }

        public void SeBlesser(int degat)
        {
            this.CurrentPV -= degat;
        }

        public void AvoirSoin(int soin)
        {
            this.CurrentPV += soin;
        }

        protected void Mourir()
        {
            Console.WriteLine($"{Nom} est mort...");
        }
    }
}
