using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_25_Evenement_02.Models
{
    public delegate void TamagochiFaimEvent(Tamagochi t);

    public class Tamagochi
    {

        #region Field
        protected int _JaugeFaim = 100;
        #endregion

        #region Constants
        private const int FAIM_MIN = 0;
        private const int FAIM_WARNING = 20;
        private const int FAIM_MAX = 100;
        #endregion

        #region Events
        public event TamagochiFaimEvent? FaimEvent = null;
        #endregion

        #region props
        public string Nom;
        public bool estVivant = true;
        #endregion

        public Tamagochi(string nom)
        {
            Nom = nom;
        }

        #region Methods
        public void PasserJournee()
        {
            _JaugeFaim -= Random.Shared.Next(10, 30);
            if(_JaugeFaim < FAIM_WARNING)
            {
                // appeler l'event
                FaimEvent?.Invoke(this);
            }

            if(_JaugeFaim <= FAIM_MIN)
            {
                Console.WriteLine($"{Nom} est mort...");
                estVivant = false;
            }
        }

        public void Nourir()
        {
            if(Random.Shared.Next(0, 2) == 1)
            {
                Console.WriteLine("Faim + 20");
                _JaugeFaim += 20;
            }
        }
        #endregion
    }
}
