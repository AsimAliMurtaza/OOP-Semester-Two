using BlackJack.BL;
using BlackJack.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle();

            Player player = new Player();
            Dealer dealer = new Dealer();

            player.AddCard(deck.DealCard());
            player.AddCard(deck.DealCard());
            dealer.AddCard(deck.DealCard());
            dealer.AddCard(deck.DealCard());

            DriverUI.playerHand();
            player.ShowHand();

            DriverUI.dealerHand();
            dealer.ShowPartialHand();

            while (player.GetHandValue() < 21)
            {
                string choice = DriverUI.hitOrStand();

                if (choice.ToLower() == "h")
                {
                    player.AddCard(deck.DealCard());
                    DriverUI.playerHand();
                    player.ShowHand();
                }
                else if (choice.ToLower() == "s")
                {
                    break;
                }
            }

            DriverUI.dealerHand();
            dealer.ShowHand();

            while (dealer.GetHandValue() < 17)
            {
                dealer.AddCard(deck.DealCard());
                DriverUI.dealerHit();
                dealer.ShowHand();
            }

            DriverUI.playerHandValue(player.GetHandValue());
            DriverUI.dealerHandValue(dealer.GetHandValue());

            if (player.GetHandValue() > 21 || (dealer.GetHandValue() <= 21 && dealer.GetHandValue() > player.GetHandValue()))
            {
                DriverUI.dealerWin();
            }
            else if (dealer.GetHandValue() > 21 || player.GetHandValue() > dealer.GetHandValue())
            {
                DriverUI.playerWin();
            }
            else
            {
                DriverUI.Tie();
            }
        }
    }
}
