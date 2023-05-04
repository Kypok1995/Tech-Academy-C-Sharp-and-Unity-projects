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
            List<string> Suits = new List<string>() { "Clubs", "Hears", "Diamonds", "Spades" }; //for all suits
            List<string> Faces = new List<string>() { "Two", "Three", "Four", "Five", "Six", // list of all faces
                                                    "Seven", "Eight", "Nine", "Ten", "Jack",
                                                    "Queen", "King", "Ace"};

            foreach (string face in Faces)
            {
                foreach(string suit in Suits)
                {
                    Card card = new Card(); //to create a new card
                    card.Suit = suit; //give a property of suit
                    card.Face = face; //give a property of face
                    Cards.Add(card); //add card to the deck
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
