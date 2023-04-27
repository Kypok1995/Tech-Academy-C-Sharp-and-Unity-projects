using System;
using System.Collections.Generic;

    class ArraysAndLists
    {
    void ArrayFunc()
    {
        Console.WriteLine("Please choose which option you would like to access:" +
            "\n1. Array of strings. \n2. Array of integers. \n3. List of strings." +
            "\nType a number of option you would like to check."); //start of program, gives a choice which option to check

        int answer = Convert.ToInt32(Console.ReadLine());
        if (answer == 1) //to show array of strings
        {
            string[] stringArray = { "Fight Club", "Interstellar", "Shining", "Pulp Fiction", "Godfather", "The Hateful 8", "Hangover", "The Shawshank Redemption", "Forrest Gump", "The Game" };
            Console.WriteLine("Here you can find array of my 10 favourite movies!\nChoose a number between 0 and 9 and check out my favourite movies!");
            int stringIndex = Convert.ToInt32(Console.ReadLine());

            if(stringIndex > stringArray.Length-1) //to display error if index not exist
            {
                Console.WriteLine("Error! This array doesn't contain element with such index!");
            }

            else //to print out result from array
            {
                Console.WriteLine("One of my favourite movies is: " + stringArray[stringIndex]);
            }
        }

        if (answer == 2) //for showing array of integers
        {
            int[] intArray = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            Console.WriteLine("Here you can find array of prime numbers below 100!\nChoose a number between 0 and 24 and check out prime numbers!");
            int intIndex = Convert.ToInt32(Console.ReadLine());

            if (intIndex > intArray.Length - 1)
            {
                Console.WriteLine("Error! This array doesn't contain element with such index!");
            }

            else
            {
                Console.WriteLine("The prime number you chosen is: " + intArray[intIndex]);
            }
        }

        if (answer == 3) //for showing list of strings
        {
            List<string> stringList = new List<string> { "Seattle", "Moscow", "Novosibirsk", "Boston", "Limassol", "Warsaw" };
          
            /* stringList.AddRange( new List<string>
            {
            }); // to add multiple objects into list*/
            


            Console.WriteLine("Here you can find list of my favourite cities!\nChoose a number between 0 and 5 and check out my favourite cities!");
            int listIndex = Convert.ToInt32(Console.ReadLine());

            if (listIndex > stringList.Count - 1)
            {
                Console.WriteLine("Error! This list doesn't contain element with such index!");
            }

            else
            {
                Console.WriteLine("One of my favourite cities is: " + stringList[listIndex]);
            }


        }
        
        else if(answer > 3) //to show error, if answer is bigger than 3
        {
            Console.WriteLine("Sorry, there are only 3 options currently available in this program.");
            return;
        }
    }
    static void Main()
        {
        var arrTest = new ArraysAndLists();
        arrTest.ArrayFunc();

        }
        
    }


