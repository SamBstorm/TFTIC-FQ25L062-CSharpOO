using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_21_Delegate_03.Models
{
    internal class CahierNotes
    {
        private List<Eleve> _eleves = new();

        public Eleve[] Eleves
        {
            get {
                return _eleves.ToArray();
            }
        }

        public void AjouterEleve(Eleve nouvelEtudiant)
        {
            _eleves.Add(nouvelEtudiant);
        }

        private double Somme(double[] notes)
        {
            double result = 0;
            foreach (double note in notes)
            {
                result += note;
            }
            return result;
        }

        private double Moyenne(double[] notes)
        {
            return Somme(notes) / notes.Length;
        }

        public void AfficherMoyennes() {
            foreach (Eleve eleve in _eleves)
            {
                eleve.DefinirOperation(Moyenne);
                Console.WriteLine($"- {eleve.Nom} {eleve.Prenom} : {eleve.CalculDesNotes()}");
            }
        }
        public void AfficherSommes()
        {
            foreach (Eleve eleve in _eleves)
            {
                eleve.DefinirOperation(Somme);
                Console.WriteLine($"- {eleve.Nom} {eleve.Prenom} : {eleve.CalculDesNotes()}");
            }
        }
    }
}
