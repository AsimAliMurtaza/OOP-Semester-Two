using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.BL
{
    internal class Dealer : Hand
    {
        public void ShowPartialHand()
        {
            Console.WriteLine(cards[0].Rank + " of " + cards[0].getSuitAsString());
            Console.WriteLine("Hidden Card");
        }
    }
}
