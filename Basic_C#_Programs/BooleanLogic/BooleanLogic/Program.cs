using System;

namespace BooleanLogic
{
    class Program
    {
        void InsuranceApproval()
        {
            Console.WriteLine("What is your age?"); //to check an age
            string age = Console.ReadLine();
            int ageInt = Convert.ToInt32(age);

            Console.WriteLine("Have you ever had a DUI?"); //to check DUI's requirement
            string dui = Console.ReadLine();
            bool duiBool = Convert.ToBoolean(dui);

            Console.WriteLine("How many speeding tickets do you have?"); // to check amount of tickets
            string ticketsCount = Console.ReadLine();
            int ticketCountInt = Convert.ToInt32(ticketsCount);

            if (ageInt >= 15 && duiBool == false && ticketCountInt <= 3 )
            {
                Console.WriteLine(" You are qualified for our insurance!");
                Console.ReadLine();
            }

           else if(ageInt < 15 && duiBool == false && ticketCountInt <= 3)
            {
                Console.WriteLine("You should be at least 15 years old! You're not qualified");
                Console.ReadLine();
            }

            else if(ageInt >= 15 && duiBool == true && ticketCountInt <= 3)
            {
                Console.WriteLine("You should don't have any DUI's! You're not qualified");
                Console.ReadLine();
            }

            else if(ageInt >= 15 && duiBool == false && ticketCountInt > 3)
            {
                Console.WriteLine("You should have no more than 3 speeding tickets. You're not qualified");
                Console.ReadLine();
            }

        }

        static void Main(string[] args)
        {
            var insurance = new Program();
            //insurance.InsuranceApproval();

            /*int num1 = 10;
            int num2 = 15;

            if (num1 >= num2)
            {
                Console.WriteLine("1st number is greater or equal to the second");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("2nd number is greater or equal to the 1st");
                Console.ReadLine();
            }*/

         /*   int num1 = 10;
            int num2 = 15;
            string result = num1 > num2 ? "number 1 is bigger" : "number 2 is bigger";
            Console.WriteLine(result);*/


        }
    }
}
