using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_09_Polymorphisme
{
    internal class Hero
    {

        private List<ObjetInventaire> _inventaire = new();

        public ObjetInventaire[] Inventaire
        {
            get
            {
                return _inventaire.ToArray();
            }
        }
        public void Loot(ObjetInventaire objet)
        {
            _inventaire.Add(objet);
        }

    }
}
