using System;

namespace MethodClassSubmissionAssigment
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new MathMethod();
            test.UselessMethod(4, 15); //Call the method in the class, passing in two numbers.
            test.UselessMethod(shownNumber:228, mathNumber:5); //Call the method in the class, specifying the parameters by name.

            Console.WriteLine("You can use a method for dividing a number by two.\nPlease input a number.");
            int number = Convert.ToInt32(Console.ReadLine());
            test.DivideByTwo(number);
        }
    }
}
