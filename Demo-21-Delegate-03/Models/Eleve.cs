using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_21_Delegate_03.Models
{
    delegate double OperationNotes(double[] notes);
    internal class Eleve
    {
        private List<double> _notes = new();
        private OperationNotes _operation;

        public string Nom { get; private set; }
        public string Prenom { get; private set; }

        public Eleve(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }

        public void AjouterNote(double note)
        {
            _notes.Add(note);
        }

        public void DefinirOperation(OperationNotes operation)
        {
            _operation = operation;
        }

        public double CalculDesNotes()
        {
            if (_operation is null) throw new InvalidOperationException("Définissez d'abord une opération");
            return _operation(_notes.ToArray());
        }
    }
}
