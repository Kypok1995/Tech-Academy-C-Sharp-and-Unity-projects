using System;


namespace MathApplication1._1
{
    class Income
    {
        void IncomeCompare()
        {
            Console.WriteLine("Welcome to Anonymous Income Comparison Program!");

            //To calculate 1st person salary
            Console.WriteLine("Person 1 details \nPlease enter your hourly rate");
            string person1Rate = Console.ReadLine();
            int person1RateInt = Convert.ToInt32(person1Rate);
            Console.WriteLine("Enter ampunt of hours you work weekly!");
            string person1Hours = Console.ReadLine();
            int person1HoursInt = Convert.ToInt32(person1Hours);
            double person1Salary = person1HoursInt * person1RateInt * 52;

            //To calculate 2nd person salary
            Console.WriteLine("Person 2 details \nPlease enter your hourly rate");
            string person2Rate = Console.ReadLine();
            int person2RateInt = Convert.ToInt32(person2Rate);
            Console.WriteLine("Enter ampunt of hours you work weekly!");
            string person2Hours = Console.ReadLine();
            int person2HoursInt = Convert.ToInt32(person2Hours);
            double person2Salary = person2HoursInt * person2RateInt * 52;

            //To show annual salary of each person
            Console.WriteLine("Person 1 annual gross salary is: " + person1Salary);
            Console.WriteLine("Person 2 annual gross salary is: " + person2Salary);

            //To compare salaries
            bool biggerSalary = person1Salary > person2Salary;
            Console.WriteLine("Does Person 1 make more money than Person 2?");

            if (biggerSalary == true)
            {
                Console.WriteLine("Yes, person 1 makes more money");
                Console.Read();
            }

            else
            {
                Console.WriteLine("No, person 2 makes more money");
                Console.Read();
            }



        }

        static void Main()
        {
            var compare = new Income();
            compare.IncomeCompare();

        }




    }
    }

