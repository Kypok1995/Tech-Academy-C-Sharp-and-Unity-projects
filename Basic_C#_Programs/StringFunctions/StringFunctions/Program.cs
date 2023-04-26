using System;
using System.Text;

namespace StringFunctions
{
    class StringFunc
    {

        void concateString()
        {
            Console.WriteLine("What is your first name? Please type it in"); //to get a user's input for first name
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name? Please type it in"); //to get a user's input for last name
            string lastName = Console.ReadLine();

            Console.WriteLine("What is your middle name? Please type it in"); //to get a user's input for middle name
            string middleName = Console.ReadLine();

            string fullName = lastName + " " + firstName + " " + middleName; //to concatenate 3 strings into full name
            Console.WriteLine("Your full name is: " + fullName);

            Console.WriteLine(fullName + ", do you want to caputalize your name? Answer \"yes\" or \"no\" ");
            string answer = Console.ReadLine();

            if (answer == "yes") //to show a user his name in capital letters
            {
                Console.WriteLine("Your name in uppercase will be: " + fullName.ToUpper());
            }

            Console.WriteLine(fullName + ", do you want to create a text paragraph? Answer \"yes\" or \"no\" ");
            string secondAnswer = Console.ReadLine();

            if (secondAnswer == "yes")
            {
                Console.WriteLine("How many sentences do you want to have in your paragraph? Indicate a number"); //to make a limit for a forLoop
                int numberOfSentences = Convert.ToInt32(Console.ReadLine());

                StringBuilder paragraph = new StringBuilder(); //for loop which takes user's input and append a strings within user's indicated limit of sentenses
                for(int i = 0; i < numberOfSentences; i++)
                {
                    Console.WriteLine("Write a sentense №" + (i+1));
                    paragraph.Append(Console.ReadLine() + " ");
                }
                Console.WriteLine("Your full paragraph is here: \n" + paragraph); //to show combined string to the user

            }

            Console.WriteLine("Thanks for using my program and have a good day!");
            return;
        }
        static void Main(string[] args)
        {
            /*string quote = "The man said, \"Hey, Andrei!\" \nHello on new line \n\tHello with new line and tab";

            string name = "Andrei";

            bool trueName = name.Contains("b"); //to check if string contain some letters
            trueName = name.EndsWith("s");//to check last digits of string
            int stringLength = name.Length; //return amount of letters inside string
            Console.WriteLine(stringLength);*/

            /*StringBuilder sb = new StringBuilder(); //to aboid creating new memory locations than assigning new value to string
            sb.Append("My name is Andrei");
            Console.WriteLine(sb);*/

            var test = new StringFunc();
            test.concateString(); //this function takes an input into 3 string and concates them together, after it gives choice to capitalize a combined string and after it gives a choice to make a sentense, using a StringBuilder 


            

        }
    }
}
