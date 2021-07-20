using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDeckUI
{
    class Card : IComparable<Card>
    {
        public Suit Suit { get; set; }
        public int Value { get; set; }

        public Card(Suit suit, int value)
        {
            Suit = suit;
            Value = value;
        }

        public override string ToString()
        {
            if (Value == 11)
            {
                return $"Jack of {Suit}";
            }
            else if (Value == 12)
            {
                return $"Queen of {Suit}";
            } else if (Value == 13)
            {
                return $"King of {Suit}";
            }

            return $"{Value} of {Suit}";
        }

        public int CompareTo(Card otherCard)
        {
            if (Suit > otherCard.Suit)
            {
                return 1;
            } else if (Suit < otherCard.Suit)
            {
                return -1;
            } else
            {
                return Value.CompareTo(otherCard.Value);
            }
        }
    }

    enum Suit
    {
        Spides,
        Clubs,
        Diamonds,
        Hearts
    }
}
