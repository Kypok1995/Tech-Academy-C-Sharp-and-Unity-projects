using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssigment
{
    public class MathMethod
    {

        public int NumberToPower(int number, int power = 2)
        {

            double numberDouble = (double)number;
            double powerDouble = (double)power;
            double resultDouble = Math.Pow(numberDouble, powerDouble);
            int result = (int)resultDouble;
            return result;
        }
    }
}