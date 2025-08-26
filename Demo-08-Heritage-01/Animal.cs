using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_08_Heritage_01
{
    internal class Animal
    {
        public DateOnly BirthDate { get; set; }
        public string Nom { get; set; }
        public Personne? Proprietaire { get; set; }

        private ushort _niveauFaim = 0;

        public bool AvoirFaim
        {
            get {
                return _niveauFaim >= 5;
            }
        }

        private ushort NiveauFaim
        {
            get { return _niveauFaim; }
            set
            {
                if (value < 0) value = 0;
                _niveauFaim = value;
            }
        }

        public void Manger()
        {
            NiveauFaim -= 2;
        }

        public void Vivre()
        {
            NiveauFaim++;
            if (AvoirFaim)
            {
                Crier();
            }
        }

        protected virtual void Crier()
        {
            Console.WriteLine("J'ai faim!");
        }

        public override string ToString()
        {
            return $" :\nNom : {this.Nom}\nDate de naissance : {this.BirthDate}\nNiveau Faim : {this.NiveauFaim}";
        }
    }
}
