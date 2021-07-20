using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDeckUI
{
    class CardList
    {
        public List<Card> Cards = new List<Card>();

        public void CreateNewDeck()
        {
            for (int i = 1; i < 14; i++)
            {
                Cards.Add(new Card(Suit.Spides, i));
            }

            for (int i = 1; i < 14; i++)
            {
                Cards.Add(new Card(Suit.Clubs, i));
            }

            for (int i = 1; i < 14; i++)
            {
                Cards.Add(new Card(Suit.Diamonds, i));
            }

            for (int i = 1; i < 14; i++)
            {
                Cards.Add(new Card(Suit.Hearts, i));
            }
        }

        public void Remove(Card card)
        {
            Cards.Remove(card);
        }
    }
}
