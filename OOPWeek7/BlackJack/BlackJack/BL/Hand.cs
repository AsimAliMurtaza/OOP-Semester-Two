using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.BL
{
    internal class Hand
    {
        protected Card[] cards;
        protected int numCards;
        public Hand()
        {
            cards = new Card[10];
            numCards = 0;
        }

        public void AddCard(Card card)
        {
            if (numCards < cards.Length)
            {
                cards[numCards] = card;
                numCards++;
            }
        }
        public int GetHandValue()
        {
            int value = 0;
            int numAces = 0;

            for (int i = 0; i < numCards; i++)
            {
                int cardValue = 0;

                if (cards[i].Rank == 1)
                {
                    cardValue = 1;
                    numAces++;
                }
                else if (cards[i].Rank == 2 || cards[i].Rank == 3 || cards[i].Rank == 4 || cards[i].Rank == 5 || cards[i].Rank == 6 || cards[i].Rank == 7 || cards[i].Rank == 8 || cards[i].Rank == 9 || cards[i].Rank == 10)
                {
                    cardValue = cards[i].Rank;
                }
                else
                {
                    cardValue = 10;         
                }
                value += cardValue;
            }

            for (int i = 0; i < numAces; i++)
            {
                if (value + 10 <= 21)
                {
                    value += 10;
                }
            }
            return value;
        }

        public void ShowHand()
        {
            for (int i = 0; i < numCards; i++)
            {
                Console.WriteLine(cards[i].Rank + " of " + cards[i].getSuitAsString());
            }
        }
    }
}
