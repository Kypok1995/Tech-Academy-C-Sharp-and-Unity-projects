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

        public decimal MathMethod (decimal number)
        {
            double numberDouble = Convert.ToDouble(number);
            double resultDouble = Math.Sqrt(numberDouble);
            decimal result = Convert.ToDecimal(resultDouble);

            return result;
        }

        public int MathMethod(string numberString)
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
