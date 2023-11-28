using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinationOfPhoneNumberChallenge
{
    public class Solution
    {
        public IList<string> LetterCombinations(string digits)
        {
            if (string.IsNullOrEmpty(digits))// Return an empty list for empty digits
            {
                return new List<string>(); 
            }

            // Create a Dictionary with key-value pairs
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>
        {
            { 2, "abc" },
            { 3, "def" },
            { 4, "ghi" },
            { 5, "jkl" },
            { 6, "mno" },
            { 7, "pqrs" },
            { 8, "tuv" },
            { 9, "wxyz" }
        };

            List<string> combinations = new List<string>();
            GenerateCombinationsHelper(digits, keyValuePairs, 0, "", combinations);
            return combinations;
        }

        static void GenerateCombinationsHelper(string digits, Dictionary<int, string> keyValuePairs, int index, string currentCombination, List<string> combinations)
        {
            if (index == digits.Length)
            {
                // Add the current combination to the list
                combinations.Add(currentCombination);
                return;
            }

            int digit = int.Parse(digits[index].ToString());

            // Check if the digit is a key in the dictionary
            if (keyValuePairs.TryGetValue(digit, out string value))
            {
                // Generate combinations for the next index
                foreach (char c in value)
                {
                    GenerateCombinationsHelper(digits, keyValuePairs, index + 1, currentCombination + c, combinations);
                }
            }
        }
    }
}
