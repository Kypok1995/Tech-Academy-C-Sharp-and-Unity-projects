using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethods
{
    class MathFunctions
    {

        public int Power(int number) //to put a number into 3rd power
        {
            double resultDouble = Math.Pow(number, 3);
                
            int result = Convert.ToInt32(resultDouble);
            return result;
        }

        public int Remainder(int number) 
        {
            int result = 100 % number;

            return result;
        }

        public int factorial(int number)
        {
        int result = 1;
        while (number != 1)
        {
        result = result * number;
        number = number - 1;
        }
        return result;
        }
    }
}
