using System;

namespace Enums
{
    class Program
    {
        public enum DaysOfWeek //declaring an enum
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please enter a current day of week");
            while (true) //to repeat a loop until user promt a day of week
            {
                try
                {
                    string input = Console.ReadLine(); //making user input into string

                    DaysOfWeek today = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), input, true); //use Enum.parse method to assign user input into variable of enum data type
                    Console.WriteLine("Seems today is " + today); //print out user input
                    break; //end a program
                }

                catch (ArgumentException)
                {
                    Console.WriteLine("Please enter an actual day of the week."); 
                }
            }
           
            
        }
    }
}
