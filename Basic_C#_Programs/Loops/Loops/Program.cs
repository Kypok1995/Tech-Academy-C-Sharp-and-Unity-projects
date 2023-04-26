using System;

namespace Loops
{
    class Loops
    {
        void WhileLoop()
        {
            bool isFriday = false;
            while (isFriday == false) //while loop with boolean expression
            {
                Console.WriteLine("What is a day today?");
                string dayOfWeek = Console.ReadLine();

                if (dayOfWeek == "Friday")
                {
                    Console.WriteLine("It is Friday today! Enjoy your weekends!");
                    isFriday = true;
                    return;
                }

                Console.WriteLine("It is not a friday yet");

            }

           
        }

        void DoWhileLoop()
        {
            bool isQualified = false;
            do
            {


                Console.WriteLine("Let's see if you're qualified to apply for auto-loan in our bank!");
                Console.WriteLine("What is your current credit score?");
                int creditScore = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is your annual income?");
                int annualIncome = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What amount of loan you would like to request?");
                int loanAmount = Convert.ToInt32(Console.ReadLine());

                float minimumIncome = (annualIncome - loanAmount) / 12;

                if (creditScore >= 650 && minimumIncome >= 2500)
                {
                    isQualified = true;
                    Console.WriteLine("You are qualified to apply for our auto-loan!");
                    return;
                }

                Console.WriteLine("Seems you are not qualified, but don't worry you can try one more time with another numbers!");
            }
            while (isQualified == false);
        }

        static void Main(string[] args)
        {
            var loops = new Loops();
            // loops.WhileLoop(); //to call while loop function with boolean expression
            loops.DoWhileLoop(); // to call a do while loop
        }
    }
}
