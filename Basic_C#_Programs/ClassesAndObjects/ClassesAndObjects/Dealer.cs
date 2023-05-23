using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)//method to deal a card by dealer
        {
            Hand.Add(Deck.Cards.First());
            string card = String.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            using(SteamWriter file = new SteamWriter(@"C/Users/", true)); //for logging every card dealed 
            {
                file.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0);
        }


    }
}
