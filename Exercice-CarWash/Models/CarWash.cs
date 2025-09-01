using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_CarWash.Models
{
    delegate void CarWashDelegate(Voiture v);
    internal class CarWash
    {
        private CarWashDelegate? _traitement;

        public CarWash()
        {
            /* Exercice 2 - Suppression des méthodes
            _traitement = Preparer;
            _traitement += Laver;
            _traitement += Secher;
            _traitement += Finaliser;*/
            _traitement = delegate (Voiture v)
            {
                Console.WriteLine($"Je prépare la voiture : {v.Plaque}.");
            };
            _traitement += delegate (Voiture v)
            {
                Console.WriteLine($"Je lave la voiture : {v.Plaque}.");
            };
            _traitement += delegate (Voiture v)
            {
                Console.WriteLine($"Je sèche la voiture : {v.Plaque}.");
            };
            _traitement += delegate (Voiture v)
            {
                Console.WriteLine($"Je finalise la voiture : {v.Plaque}.");
            };
        }
        /* Exercice 2 - Suppression des méthodes
        private void Preparer(Voiture v)
        {
            Console.WriteLine($"Je prépare la voiture : {v.Plaque}.");
        }
        private void Laver(Voiture v)
        {
            Console.WriteLine($"Je lave la voiture : {v.Plaque}.");
        }
        private void Secher(Voiture v)
        {
            Console.WriteLine($"Je sèche la voiture : {v.Plaque}.");
        }
        private void Finaliser(Voiture v)
        {
            Console.WriteLine($"Je finalise la voiture : {v.Plaque}.");
        }
        */
        public void Traiter (Voiture v)
        {
            _traitement?.Invoke(v);
        }
    }
}
