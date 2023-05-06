using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSubmissionAssigment
{
    static class MathMethod
    {
        public static int test;
        public static void DivideByTwo(int number) //Create a class. In that class, create a void method that outputs an integer. Have the method divide the data passed to it by 2
        {
            Console.WriteLine("Your number " + number + " divided by two equals: " + number / 2);
        }

        public static void DivideByTwo(double number, out double result)//overload a method + out parameter
        {
            result = number / 2;
            Console.WriteLine("Your number " + number + " divided by two equals: " + result);

        }
    }
}
