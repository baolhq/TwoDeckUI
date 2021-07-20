using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDeckUI
{
    class RandomCardComparer : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            Random random = new Random();

            // Return 0, 1, 2
            int rng = random.Next(0, 3);

            return rng - 1;
        }
    }
}
