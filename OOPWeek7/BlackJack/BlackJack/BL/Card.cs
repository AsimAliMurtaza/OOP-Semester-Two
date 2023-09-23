using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.BL
{
    internal class Card
    {
        public int Rank;
        public int Suit;
        public Card(int rank, int suit)
        {
            Rank = rank;
            Suit = suit;
        }
        public int getRank()
        {
            return this.Rank;
        }
        public int getSuit()
        {
            return this.Suit;
        }
        public string getSuitAsString()
        {
            if(Suit == 1)
            {
                return "Clubs";
            }
            else if(Suit == 2)
            {
                return "Diamonds";
            }
            else if (Suit == 3)
            {
                return "Spades";
            }
            else
            {
                return "Hearts";
            }
        }
        public string getRankAsString()
        {
            if(Rank==1)
            {
                return "Ace";
            }
            else if(Rank==11)
            {
                return "Queen";
            }
            else if(Rank==12)
            {
                return "Jack";
            }
            else if(Rank==13)
            {
                return "King";
            }
            else
            {
                return Rank.ToString();
            }
        }
    }
}
