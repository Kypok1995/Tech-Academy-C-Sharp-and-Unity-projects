using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethods
{
    class MathFunctions
    {

        public double Power(double number) //to put a number into 3rd power
        {
            double result = Math.Pow(number, 3);

            return result;
        }

        public double Remainder(double number)
        {
            double result = 100 % number;

            return result;
        }

        public double factorial_While_Loop (double number){
        double result = 1;
            while (number != 1)
            {
            result = result * number;
            number = number - 1;
            }
        return result;
        }
    }
}
