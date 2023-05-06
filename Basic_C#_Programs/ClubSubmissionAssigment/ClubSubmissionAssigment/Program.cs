using System;

namespace ClubSubmissionAssigment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("In this program you can divide your number by two.\nPlease enter the integer");
            while (true)
            {
                try
                {
                    //var test = new MathMethod(); //In the Main() method, instantiate that class. Not actual for static class
                    int number = Convert.ToInt32(Console.ReadLine());
                    //test.DivideByTwo(number); //Have the user enter a number. Call the method on that number. Display the output to the screen. It should be the entered number, divided by two.

                    MathMethod.DivideByTwo(number);//same method with static class

                    Console.WriteLine("Here you can find overloaded method with out parameter. This method can divide number with floating point.\nPlease enter any number");
                    double numberDouble = Convert.ToDouble(Console.ReadLine());
                    double result;
                    MathMethod.DivideByTwo(numberDouble, out result); //use an overloaded method with parameter in static class

                    break;
                }

                catch (FormatException)
                {
                    Console.WriteLine("You should enter integer!");
                }

                catch(OverflowException)
                {
                    Console.WriteLine("Your entered number is too big for integer.\nEnter number between -2,147,483,648 and 2,147,483,647");
                }

             
            }

            
          
            
        }
    }
}
