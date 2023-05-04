using System;

namespace MethodSubmissionAssigment
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the program! This program can count any power of any integer for you!\nPlease enter the number you want to raise to the power.");
            while (true) //while loop to keep asking user to input integer, if he did a wront input
            {
                try
                {
                    var test = new MathMethod(); //to create a new instance of mathmethod class
                    int userNumber = Convert.ToInt32(Console.ReadLine()); //input first parameter (not optional)
                    Console.WriteLine("You can also enter the power you want to raise the number to.\nIf no power is entered, the number will be raised to the second power.");

                    string userPowerStr = Console.ReadLine();

                    if (string.IsNullOrEmpty(userPowerStr)) //checks if user didn't input second parameter
                    {
                        Console.WriteLine("Here you can see result of raising your number " + userNumber + " to the second power: " + test.NumberToPower(userNumber));
                        break;
                    }
                    else //works if user input two parameters
                    {
                        int userPower = Convert.ToInt32(userPowerStr);

                        Console.WriteLine("Here you can see result of raising your number " + userNumber + " to the " + userPower + " power: " + test.NumberToPower(userNumber, userPower));
                        break;
                    }
                }

                catch (FormatException)
                {
                    Console.WriteLine("Please input an integer!");
                }

            }

        }
    }
}