using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmissionAssigment
{
    class MathMethod
    {
        public void UselessMethod(int mathNumber, int shownNumber)
        {
            mathNumber = Convert.ToInt32(Math.Pow(mathNumber, 2)); //do math operation with first parameter
            Console.WriteLine("The second parameter of this method is: " + shownNumber); //display the second integer to the screen.
        }

        public void DivideByTwo(int number) //method to divide a number by two
        {
            Console.WriteLine("Your number divided by two equals: " + number/2);
        }



    }
}
