using System;

namespace MathMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new MathFunctions();

           Console.WriteLine("Here you can find 3 math functions:" +
                            "\n1.Function for raising a number to the third power" +
                            "\n2.Function which returns a remainder of division of 100 by user\'s number"+
                            "\n3. Function for finding factorial."+ 
                            "\nPlease input one integer for all 3 functions");
            
            int number = Convert.ToInt32(Console.ReadLine());

            int resultOne = test.Power(number);
            int resultTwo = test.Remainder(number);
            int resultThree = test.factorial(number);

            Console.WriteLine("Result of raising a number to the third power is " + resultOne +
                            "\nRemainder of division of 100 by your number is " + resultTwo +
                            "\nFactorial of your number is " + resultThree);
        }
    }
}
