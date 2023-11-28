// See https://aka.ms/new-console-template for more information
using CombinationOfPhoneNumberChallenge;

Solution solution = new Solution();
string digits = "292";

IList<string> combinations = solution.LetterCombinations(digits);

foreach (string combination in combinations)
{
    Console.WriteLine(combination);
}





