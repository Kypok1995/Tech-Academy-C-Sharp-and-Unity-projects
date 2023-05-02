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
    }
}
