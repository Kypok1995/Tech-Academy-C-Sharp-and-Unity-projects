﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }

        public override void Play() //abstract method from abstract class with implementation in inherited class. Inherited class must have implementation for abstract method
        {
            Dealer = new TwentyOneDealer(); //instantiate new dealer
            foreach (Player player in Players) //loop to give all players a new cards 
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>(); //get a dealer a card
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();
            Console.WriteLine("Place your bet!");

            foreach (Player player in Players) //to make all players make their bets
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successFullyBet = player.Bet(bet); //use a bet method to check if player has enough money to make a bet
                if (!successFullyBet) //if player have not enough money for his bet
                {
                    return;
                }
                Bets[player] = bet;//store players bet in the bets dictionary
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1)
                    {
                        bool BlackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (BlackJack)// if player have a blackjack, blackjack checks immidiately after dealing a cards
                        {
                            Console.WriteLine("BlackJack!!! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]); //to return bet to the player, plus give him his reward
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
                    if (BlackJack)
                    {
                        Console.WriteLine("Dealer has a Black Jack! Everybody looses their bets");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.Stay)//loop until player not stay
                {
                    Console.WriteLine("Your cards are:  ");//to ouput user's cards 
                    foreach (Card card in player.Hand)
                    {
                        Console.Write(" {0}", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or stay?");
                    string answer = Console.ReadLine().ToLower();

                    if (answer == "stay")//if players stay - break a loop
                    {
                        player.Stay = true;
                        break;
                    }

                    else if (answer == "hit") //deal one more card if member want to hit
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);//check if there are conditons for user to be busted
                    if (busted)//if busted condition met 
                    {
                        Dealer.Balance += Bets[player]; //dealer receive a player's bet
                        Console.WriteLine("{0} Busted! You loose your bet of {1}. Your remaining balance is {2}", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeh" || answer == "y" || answer == "ya")//if user want to play again after beign busted
                        {
                            player.isActivelyPlaying = true;
                            return;
                        }

                        else
                        {
                            player.isActivelyPlaying = false;
                            return;
                        }
                    }

                }
            }

            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);//check if dealer is busted
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);

            while (!Dealer.Stay && !Dealer.isBusted)//loops until dealer not busted and not staying
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand); //add more card to dealer hand
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand); //check for busted condition
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand); //check for stay condition
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying");
            }
            if (Dealer.isBusted)//if dealer busted
            {
                Console.WriteLine("Dealer is busted!");
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2); //to get all names of players who won and give them their bet x2
                    Dealer.Balance -= entry.Value; //take of a bet from dealer
                }
                return;
            }
            foreach (Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);//create a bool with nullable value a use a method to compare hands of dealer and user
                if (playerWon == null) //if value null -  it is a push
                {
                    Console.WriteLine("Push! No one wins!");
                    player.Balance += Bets[player];
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}", Bets[player]);
                    Dealer.Balance += Bets[player];
                }
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
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
