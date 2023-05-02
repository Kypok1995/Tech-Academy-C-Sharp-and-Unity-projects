using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck = Shuffle(deck);

            foreach(Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);

            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);

        }
        public static Deck Shuffle(Deck deck) //public method with deck return type and deck parameter
        {
            List<Card> TempList = new List<Card>(); //temporary list for storing shuffled values
            Random random = new Random(); //new instance of class random

            while(deck.Cards.Count > 0) //until all cards removed from list
            {
                int randomIndex = random.Next(0, deck.Cards.Count); //random between 0 and 52
                TempList.Add(deck.Cards[randomIndex]); //add a card at random index to a temporary deck
                deck.Cards.RemoveAt(randomIndex); //remove from main deck
            }
            deck.Cards = TempList; //assign a main deck values from temporary (shuffled) deck
            return deck; //return shuffled deck

        }
    }
}
