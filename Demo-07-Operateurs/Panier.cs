using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_07_Operateurs
{
    internal class Panier
    {
        private List<Fruit> _fruits = new();

        public int Count { 
            get {
                return _fruits.Count;
            } 
        }

        public void Ajouter(Fruit newFruit)
        {
            _fruits.Add(newFruit);
        }

        public static Panier operator +(Panier left, Panier right)
        {
            Panier result = new();
            foreach (Fruit f in left._fruits)
            {
                result.Ajouter(f);
            }
            foreach (Fruit f in right._fruits)
            {
                result.Ajouter(f);
            }

            return result;
        }

        public static Panier operator + (Panier left, Fruit right)
        {
            left.Ajouter(right);
            return left;
        }

        public static bool operator ==(Panier left, Panier right)
        {
            return left.Count == right.Count;
        }

        public static bool operator !=(Panier left, Panier right)
        {
            return left.Count != right.Count;
        }

        public static bool operator >(Panier left, int right)
        {
            return left.Count > right;
        }
        public static bool operator <(Panier left, int right)
        {
            return left.Count < right;
        }
    }
}
