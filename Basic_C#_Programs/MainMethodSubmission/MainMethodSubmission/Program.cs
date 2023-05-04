using System;

namespace MainMethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new MathMethodClass();
            Console.WriteLine("This is a first method, it counts area of circle with circle radius as parameter: " +  test.MathMethod(5)); //take int as parameter, return int
            Console.WriteLine("This is a second method, it returns a square root of decimal number: "+ test.MathMethod(25m)); //take decimal as parameter, return integer
            Console.WriteLine("This is third method, it returns a factorial of number: " + test.MathMethod("5")); // take string as parameter, return integer



        }
    }
}
