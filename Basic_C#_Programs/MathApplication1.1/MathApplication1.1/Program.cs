using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApplication1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int total = 5 + 1488;
            int otherTotal = 10 + 15;
            int combined = total + otherTotal;
            Console.WriteLine(combined);
            Console.ReadLine();*/

            /* int difference = 15 - 48;
             Console.WriteLine("Fifteen minus forty-eight should be: " + difference);
             Console.ReadLine();*/

            /*double division = 450 / 17.5;
            Console.WriteLine(division);
            Console.ReadLine();*/

            Console.WriteLine("Write any number and check is it even or odd?");
            string xStr = Console.ReadLine();
            int x = Convert.ToInt32(xStr);
            int reminder = x % 2;

            if (reminder == 0)
            {
                Console.WriteLine("Your number is even");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Your number is odd");
                Console.ReadLine();
            }
        }

            


        }
    }

