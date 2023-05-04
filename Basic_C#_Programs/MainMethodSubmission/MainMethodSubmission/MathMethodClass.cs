using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    class MathMethodClass
    {

        public int MathMethod(int number) //method for finding an area of circle (approximate as it return an integer) 
        {
            double radiusDouble = Math.Pow(number, 2);
            int radiusSquared = Convert.ToInt32(radiusDouble);
            double circleAreaDouble = radiusSquared * Math.PI;
            int circleArea = Convert.ToInt32(circleAreaDouble);

            return circleArea;
        }

        public int MathMethod (decimal number) //method for finding a square root of decimal number, using sqrt function
        {
            double numberDouble = Convert.ToDouble(number);
            double resultDouble = Math.Sqrt(numberDouble);
            int result = Convert.ToInt32(resultDouble);

            return result;
        }

        public int MathMethod(string numberString) //method for finding a factorial of the number
        {
            int number = Convert.ToInt32(numberString);
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
