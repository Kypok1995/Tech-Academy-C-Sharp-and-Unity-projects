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
            Dealer = new TwentyOneDealer();
            foreach(Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Comsole.WriteLine("Place your bet!");

            foreach(Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successFullyBet =  player.Bet(bet);
                if (!successFullyBet)
                {
                    return;
                }
                Bets[player] = bet;
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
