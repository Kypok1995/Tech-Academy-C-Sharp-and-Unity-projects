using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneRules
    {
     private static Dictionary <Face, int> _cardValues = new Dictionary<Face, int>() //dictionary to hold valuers of all cards
     {
        [Face.Two] = 2,
        [Face.Three] = 3,
        [Face.Four] = 4,
        [Face.Five] = 5,
        [Face.Six] = 6,
        [Face.Seven] = 7,
        [Face.Eight] = 8,
        [Face.Nine] = 9,
        [Face.Ten] = 10,
        [Face.Jack] = 10,
        [Face.Queen] = 10,
        [Face.King] = 10,
        [Face.Ace] = 1
     };

     private static int[] GetAllPossibleValues(List<Card>Hand)
     {
        int aceCount = Hand.Count(x => x.Face == Face.Ace); //lambda expression to count a number of aces
        int[] results = new int[aceCount + 1]; //total length of results array will be amount of aces +1 
        int value = Hand.Sum(x => _cardValues[x.Face]); //counting first possible result with aces as 1
        results[0] = value; //putting first result into first place at array
        if (results.Length ==1) return results; //if there no aces, results returned as only one possible option

        for (int i = 1; i < results.Length; i++)
        {
         value = value + (i*10); //to add amount of aces to a combined value
         results[i] = value;
        }

        return results;
     }
     
     public static bool CheckForBlackJack(List<Card> Hand)
     {
      int [] possibleValues = GetAllPossibleValues(Hand);//to put a values into array
      int value = possibleValues.Max(); //to get a biggest possible value
      if(value == 21) return true; //it is black jack
      else return false;
     }

    public static bool IsBusted(List<Card> Hand)
      {
      int value = GetAllPossibleValues(Hand).Min();//check minimum value from the hand
      if (value > 21) return true;//if value more than 21 - it is busted, return true
      else return false; //if not return false
      }

   public static bool ShouldDealerStay(List<Card> Hand) //check if dealer should stay or hit. If his score is between 16 and 21 he stays, overwise he hits
        {
            int[] possibleHandValues = GetAllPossibleValues(Hand);
            foreach(int value in possibleHandValues)
            {
                if (value > 16 && value < 21) //if dealers hand between 16 and 21 - dealer stays
                {
                    return true;
                }
            }
            return false;
       }

        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleValues(PlayerHand); //get all possible values of users hand into array 
            int[] dealerResults = GetAllPossibleValues(DealerHand);// get all possible values of dealers hand into array

            int playerScore = playerResults.Where(x => x < 22).Max(); //choose 
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;
            else if (dealerScore > playerScore) return false;
            else return null;
        }

  }

}