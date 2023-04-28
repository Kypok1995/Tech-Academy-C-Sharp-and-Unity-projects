using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
       

        void addToArray() //function for first part of assigment
        {
            string[] favouriteThing = {"I am a huge fun of ", "Can you please sell me some ", "The best day of my life was than I found ", "I don't understand why you don't like ",
                            "I spend all my money for "};

            Console.WriteLine("Welcome to my program! \nPlease type name of one of your favourite things");
            string answer = Console.ReadLine();

            for (int i = 0; i < favouriteThing.Length; i++) //to iterate and add user input to arrays strings
            {
                favouriteThing[i] = favouriteThing[i] + answer; //adds user's answer to array's string
            }

            Console.WriteLine("You succesfully add your word to string array! Now I'll type out results.");

            for (int i = 0; i < favouriteThing.Length; i++) //to show all strings from array
            {
                Console.WriteLine(favouriteThing[i]);
            }
        }

        void infiniteLoop() //function for second part of assigment
        {
            bool goodWeather = false;

            while(goodWeather == false)
            {
                Console.WriteLine("What is temperature outside?");
                int temperature = Convert.ToInt32(Console.ReadLine());


                if (temperature > 50) //without this if statement loop was infinite
                {
                    goodWeather = true;
                    Console.WriteLine("Time to go outside!");
                    return;
                }

                Console.WriteLine("It's better to sit home today!");
            }

           
        }

        void compareLoop1() //for 3rd part of assigment
        {
            Console.WriteLine("What is your favourite number?\nPlease type a number");
            int favouriteNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < favouriteNumber; i++)
            {
                Console.WriteLine("Here is all numbers above your favourite number:" + i);
            }

        }

        void compareLoop2() //second part of 3rd part of the assigment
        {
            Console.WriteLine("What is your age?\nPlease type a number");
            int userAge = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i <= userAge; i++)
            {
                Console.WriteLine("Person of age " + i + " is younger or a same age as you");
            }
        }

        void searchList() //for 4th part of assigment
        {
            List<string> names = new List<string>{"John", "Jessi", "Adam", "Thomas", "Liam", "Isabella", "Sophia", "Emma", "Mason", "William", "Frank", "Joshua", "Jacob",
                                                 "Justin", "Sarah", "Mary", "Patricia", "Jennifer", "Elizabeth"};

            Console.WriteLine("In this function you can find a list of most popular American names! You can check, if your name is popular or not!\nPlease type your name");
            string userName = Console.ReadLine(); //to put user's input into string

            foreach (string name in names) 
            {
                if (name.ToUpper().Contains(userName.ToUpper())) //to check if there are a match with some name from list
                {
                    int index = names.IndexOf(name); //to check index of this name 
                    
                    Console.WriteLine("Nice, " + userName + ", program find your name in the list with an index of: " + index); //type a result for user

                    return; //stop executing a loop
                }
            }

            Console.WriteLine("Sorry, " + userName + ", your name is not in the list."); //to display if there are no such name in the list

        }

        void searchList2() //for 5th part of assigment
        {
            List<string> bestDishes = new List<string> {"Sausage", "Cronut", "French fries", "Chicken and Waffles", "Pancakes", 
                "Mac and Cheese", "Hot Dogs", "Cheesecake", "Burger", "Burger with french fries", "Chicken wings", "Hot Dog with sausage", "Pancakes", "Burger"};

            Console.WriteLine("In this function you can find a list of most popular American dishes! You can check, if your dish is popular or not!\nPlease type your favourite dish");
            string userDish = Console.ReadLine(); //to put user's input into string

            int dishCount = 0; // variable to store amount of times foreach loop finds some matches in the list
            foreach (string dish  in bestDishes)
            {
                if (dish.ToUpper().Contains(userDish.ToUpper())) //to check if there are a match with some dish from list
                {
                    int index = bestDishes.IndexOf(dish); //to check index of this dish

                    Console.WriteLine("You can find your favourite dish in this list with index: " + index); //type a result for user
                    dishCount++; //to add 1 if there any match
                }

            }
            
            if (dishCount == 0) //if there no any matches in the list
            {
                Console.WriteLine("There are no " + userDish + " in the list");
            }

        }

        void searchList3()
        {
            List<string> cities = new List<string> { "Paris", "New York", "Moscow", "Amsterdam", "Venice", "Moscow", "London", "New York", "Seattle", "Orlando", "Seattle" };
            List<string> previouslySeen = new List<string>();// additional list to check, if string already was shown

            foreach (string city in cities)
            {
                if (previouslySeen.Contains(city)) //checks if previouslySeen list already contain a string
                {
                    Console.WriteLine(city + " has already appeared in the list.");
                }
                else //if it doesn't contan a string - string is added to the list
                {
                    Console.WriteLine(city + " is a new city in the list.");
                    previouslySeen.Add(city);
                }
            }
        }

        void lookingForMethods() //main function for choosing between different parts of assigment
        {
            bool userWantToContinue = true;
            while (userWantToContinue == true)
            {
                Console.WriteLine("\nWelcome to my assigment program!\nHere you can find different functions:" +
                    "\n1. Function for 1st part of assigment" + "\n2. Function for 2nd part of assigment"
                    + "\n3. Function for 3rd part of assigment" + "\n4. Function for 4th part of assigment" +
                    "\n4. Function for 5th part of assigment" + "\n6. Function for 6th part of assigment" + "\nPlease enter number of function you would like to try! If you would like to leave a program enter \"0\"");

                int answer = Convert.ToInt32(Console.ReadLine());

                switch (answer)
                {
                    case 0:
                        return;

                    case 1:
                        Console.WriteLine("This function adds user's input into each item in the list of strings\n");
                        addToArray();
                        break;

                    case 2:
                        Console.WriteLine("This function basically had an infinite loop, which I fixed by adding if statement\n");
                        infiniteLoop();
                        break;

                    case 3:
                        Console.WriteLine("This part of assigment contain 2 loops: \n1.Loop with \"<\" operator \n2.Loop with \"<=\" operator \nChoose which one you want to check\n");
                        int userChoice = Convert.ToInt32(Console.ReadLine());
                        if (userChoice == 1)
                        {
                            Console.WriteLine("This function contains loop where the comparison that’s used to determine whether to continue iterating the loop is a  \"<\" operator.\n");
                            compareLoop1();
                        }
                        else if (userChoice == 2)
                        {
                            Console.WriteLine("This function contains loop where the comparison that’s used to determine whether to continue iterating the loop is a  \"<=\" operator.\n");
                            compareLoop2();
                        }
                        else
                        {
                            Console.WriteLine("There are no such option.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("This function ask user for input and check if there any matches inside string list. If it finds a matches - it return index\n");
                        searchList();
                        break;

                    case 5:
                        Console.WriteLine("This function ask user for input and check if there any matches inside string list. If it finds a matches - it return index." +
                            "\nAs list contains same items inside - function displays indexes of all matching strings\n");
                        searchList2();
                        break;

                    case 6:
                        Console.WriteLine("This function contain list of strings with some identical strings and " +
                            "loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.\n");
                        searchList3();
                        break;

                    default:
                        Console.WriteLine("This program doesn't contain such option");
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            var testVar = new Program();
            //testVar.addToArray(); //function for 1st part of assigment

            //testVar.infiniteLoop(); //for second part of assigment

            //testVar.compareLoop2(); //for 3rd part of assigment

            //testVar.searchList(); // for 4th part of assigment

            //  testVar.searchList2(); // for 5th part of assigment

            // testVar.searchList3(); //for 6th part of assigment

            testVar.lookingForMethods();





        }
    }
}
