using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Banque.Models
{
    internal class Banque
    {
        #region Version Dictionaire
        /*private Dictionary<string, Courrant> _comptes = new();
        public string Nom { get; set; }

        public Courrant? this[string numeroCompte]
        {
            get
            {
                //foreach (KeyValuePair <string, Courrant> kvp in _comptes)
                //{
                //    if (kvp.Key == numeroCompte) return kvp.Value;
                //}
                //return null;
                Courrant result;
                _comptes.TryGetValue(numeroCompte, out result);
                return result;
            }
        }

        public void Ajouter(Courrant compte)
        {
            _comptes.Add(compte.Numero, compte);
        }

        public void Supprimer(string numero)
        {
            if (!_comptes.Remove(numero)) return; //Gérer avec une exception au lieu du return
        } */
        #endregion

        #region Version List
        private List<Courrant> _comptes = new();
        public string Nom { get; set; }

        public Courrant? this[string numeroCompte]
        {
            get
            {
                //foreach (Courrant compte in _comptes)
                //{
                //    if(compte.Numero == numeroCompte) return compte
                //}
                //return null;
                return _comptes.FirstOrDefault(c => c.Numero == numeroCompte);
            }
        }
        public void Ajouter(Courrant compte)
        {
            if (_comptes.Contains(compte)) return; //Gérer avec une exception au lieu du return
            _comptes.Add(compte);
        }

        public void Supprimer(string numero)
        {
            Courrant? compteASupprimer = this[numero];
            if (compteASupprimer is null) return; //Gérer avec une exception au lieu du return
            if (!_comptes.Remove(compteASupprimer)) return; //Gérer avec une exception au lieu du return
        }
        #endregion
    }
}
