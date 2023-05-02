using System;

namespace MathMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new MathFunctions();

            double result = test.Power(5);

            Console.WriteLine(result);
        }
    }
}
