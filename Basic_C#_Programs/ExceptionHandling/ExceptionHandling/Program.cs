using System;

namespace ExceptionHandling
{
    class Program
    {
        void ArrayHandling()
        {
            int[] primeNumbers = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71,
                73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199 };
            Console.WriteLine("In this program you can find an array of prime numbers.\nEnter any integer and check out result of division of every number from array by your number!");

           

            while (true)
            {

                try
                {
                    int userNumber = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < primeNumbers.Length; i++)
                    {
                        int result = primeNumbers[i] / userNumber;

                        Console.WriteLine("Result of division of element with index " + i + " which containt element " + primeNumbers[i] + " is " + result);
                        
                    }

                    break;
                }


                catch (DivideByZeroException)
                {
                    Console.WriteLine("You cannot divide by zero!\nPlease input integer.");
                }

                catch (FormatException)
                {
                    Console.WriteLine("Incorrect format of input.\nPlease input integer");
                }

                finally
                {
                  
                   // Console.ReadLine(); // in my function finally don't make a big sense, as it is looped until executed. Additional readline just making application less intuitive
                    

                }


            }
          
        }
        static void Main(string[] args)
        {

            var exceptionCheck = new Program();
            exceptionCheck.ArrayHandling();
           
        }
    }
}
