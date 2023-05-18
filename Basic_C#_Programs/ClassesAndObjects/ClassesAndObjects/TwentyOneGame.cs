using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer {get;set;}

        public override void Play() //abstract method from abstract class with implementation in inherited class. Inherited class must have implementation for abstract method
        {
            Dealer = new TwentyOneDealer(); //instantiate new dealer
            foreach(Player player in Players) //loop to give all players a new cards 
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>(); //get a dealer a card
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Comsole.WriteLine("Place your bet!");

            foreach(Player player in Players) //to make all players make their bets
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successFullyBet =  player.Bet(bet); //use a bet method to check if player has enough money to make a bet
                if (!successFullyBet)
                {
                    return;
                }
                Bets[player] = bet;
            }
            for (int i = 0; i<2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach(Player player in Player)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    if(i ==1)
                    {
                        bool BlackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if(BlackJack)// if player have a blackjack
                        {
                            Console.WriteLine("BlackJack!!! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] *1.5) + Bets[player]); //to return bet to the player, plus give him his reward
                            Bets.Remove(player); //to remove player's bet from pool of bets
                            return;
                        }
                    }
                }
                Console.WriteLine("Dealer:  ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool BlackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand); //to check dealer's blackjack
                    if(BlackJack)
                    {
                        Console.WriteLine("Dealer has a Black Jack! Everybody looses their bets");
                        foreach(KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                    }
                }
            }
        }

        public override void ListPlayers() //override virtual method from Game class
        {
            Console.WriteLine("21 players: ");
            base.ListPlayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotFiniteNumberException();
        }
    }
}
