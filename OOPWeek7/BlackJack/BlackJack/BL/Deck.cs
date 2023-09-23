using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.BL
{
    internal class Deck
    {
        private Card[] cards;
        private int currentCard;
        private Random random;

        public Deck()
        {
            int[] ranks = { 1,2,3,4,5,6,7,8,9,10,11,12,13};
            int[] suits = { 1,2,3,4};
            cards = new Card[52];
            currentCard = 0;
            random = new Random();

            for (int i = 0; i < cards.Length; i++)
            {
                int rank = ranks[i % 13];
                int suit = suits[i / 13];
                cards[i] = new Card(rank, suit);
            }
        }
        public void Shuffle()
        {
            currentCard = 0;
            for (int i = cards.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }
        public Card DealCard()
        {
            if (currentCard < cards.Length)
            {
                Card card = cards[currentCard];
                currentCard++;
                return card;
            }
            else
            {
                return null;
            }
        }
    }
}
