using System;

namespace DateTime_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateNow = DateTime.Now;
            Console.WriteLine("Hello, current time is: " + dateNow);//Prints the current date and time to the console.
            Console.WriteLine("Enter amount of hours youw would like to add to current time");
            double hours = Convert.ToDouble(Console.ReadLine());//Asks the user for a number.


            DateTime timeLater = dateNow.AddHours(hours);

            Console.WriteLine("Time after " + hours + " hours would be: " + timeLater.ToString());


        }
    }
}
