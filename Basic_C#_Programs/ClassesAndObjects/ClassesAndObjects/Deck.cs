using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public Deck() //contstructor
        {
            Cards = new List<Card>();

            for (int i=0; i<13; i++) //for loop made with Enums for creating deck of cards
            {
                for (int j=0; j<4;j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1) //public method with deck return type and deck parameter
        {
            
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>(); //temporary list for storing shuffled values
                Random random = new Random(); //new instance of class random

                while (Cards.Count > 0) //until all cards removed from list
                {
                    int randomIndex = random.Next(0, Cards.Count); //random between 0 and 52
                    TempList.Add(Cards[randomIndex]); //add a card at random index to a temporary deck
                    Cards.RemoveAt(randomIndex); //remove from main deck
                }
                this.Cards = TempList; //assign a main deck values from temporary (shuffled) deck
            }
        }
    }
}
