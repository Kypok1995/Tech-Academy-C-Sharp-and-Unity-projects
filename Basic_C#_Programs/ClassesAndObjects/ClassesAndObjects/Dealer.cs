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
            using(StreamWriter file = new StreamWriter(@"C:\Users\Andrei\Documents\file.txt", true)) //for logging every card dealed 
            {
                file.WriteLine(DateTime.Now);//to log a time of dealing a card
                file.WriteLine(card);//log a card itself
            }
            Deck.Cards.RemoveAt(0);
        }


    }
}
