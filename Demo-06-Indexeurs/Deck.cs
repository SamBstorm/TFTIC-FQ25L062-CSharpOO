using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_06_Indexeurs
{
    internal class Deck
    {
        private List<Card> _cards = new();

        public Card? this[int index] {
            get 
            {
                if (index < 0 || index >= _cards.Count) return null;
                Card carte = _cards[index];
                _cards.Remove(carte);
                return carte;
            }
            set
            {
                if (value is null) return;
                foreach (Card c in _cards)
                {
                    if (c.Color == value.Color && c.Value == value.Value) return;
                }
                if (index < 0 || index > _cards.Count) return;
                _cards.Insert(index, value);
            }
        }

        public Card? this[Colors color, CardValues value]
        {
            get
            {
                foreach (Card c in _cards)
                {
                    if (c.Color == color && c.Value == value) return c;
                }
                return null;
            }
        }

        public void SetNewDeck()
        {
            _cards = new();
            foreach (Colors color in Enum.GetValues<Colors>())
            {
                foreach (CardValues value in Enum.GetValues<CardValues>())
                {
                    _cards.Add(new() { Color = color, Value = value});
                }
            }
        }

        public string ListCards()
        {
            string list = "";
            foreach (Card c in _cards)
            {
                list += $"{c.Value} de {c.Color}\n";
            }
            return list;
        }
    }
}
