string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";
string suggestedDonation = "";

// variables that support data entry
int maxPets = 8; //constant for petArray sizw
string? readResult; //used to hold users input
string menuSelection = "";//for choose between menu options
int petCount = 0;
string anotherPet = "y";
bool validEntry = false;
int petAge = 0;
decimal decimalDonation = 0.00m;

// 2 dimensional array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 7];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++) //initialization of 4 pets for pet array
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            suggestedDonation = "85.00";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            suggestedDonation = "49.99";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            suggestedDonation = "40.00";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            suggestedDonation = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;


    }


    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
    if (!decimal.TryParse(suggestedDonation, out decimalDonation))
    {
        decimalDonation = 45.00m;
        
    } // if suggestedDonation NOT a number, default to 45.00
    ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";
}

// display the top-level menu options
do
{
    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animalâ€™s age");
    Console.WriteLine(" 6. Edit an animalâ€™s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();

    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    Console.WriteLine($"You selected menu option {menuSelection}.");

    // use switch-case to process the selected menu option
    switch (menuSelection)
    {
        case "1":
            // List all of our current pet information
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 7; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j].ToString());
                    }
                }
            }
            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();

            break;

        case "2":
            // Add a new animal friend to the ourAnimals array
            //
            // The ourAnimals array contains
            //    1. the species (cat or dog). a required field
            //    2. the ID number - for example C17
            //    3. the pet's age. can be blank at initial entry.
            //    4. the pet's nickname. can be blank.
            //    5. a description of the pet's physical appearance. can be blank.
            //    6. a description of the pet's personality. can be blank.

            anotherPet = "y";
            petCount = 0;
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    petCount += 1;
                }
            }

            if (petCount < maxPets)
            {
                Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
            }

            while (anotherPet == "y" && petCount < maxPets)
            {
                // get species (cat or dog) - string animalSpecies is a required field 
                do
                {
                    Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalSpecies = readResult.ToLower();
                        if (animalSpecies != "dog" && animalSpecies != "cat")
                        {
                            //Console.WriteLine($"You entered: {animalSpecies}.");
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);

                // build the animal the ID number - for example C1, C2, D3 (for Cat 1, Cat 2, Dog 3)
                animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

                // get the pet's age. can be ? at initial entry.
                do
                {
                    Console.WriteLine("Enter the pet's age or enter ? if unknown");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalAge = readResult;
                        if (animalAge != "?")
                        {
                            validEntry = int.TryParse(animalAge, out petAge);
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);


                // get a description of the pet's physical appearance - animalPhysicalDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult.ToLower();
                        if (animalPhysicalDescription == "")
                        {
                            animalPhysicalDescription = "tbd";
                        }
                    }
                } while (validEntry == false);


                // get a description of the pet's personality - animalPersonalityDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPersonalityDescription = readResult.ToLower();
                        if (animalPersonalityDescription == "")
                        {
                            animalPersonalityDescription = "tbd";
                        }
                    }
                } while (validEntry == false);


                // get the pet's nickname. animalNickname can be blank.
                do
                {
                    Console.WriteLine("Enter a nickname for the pet");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalNickname = readResult.ToLower();
                        if (animalNickname == "")
                        {
                            animalNickname = "tbd";
                        }
                    }
                } while (validEntry == false);

                // store the pet information in the ourAnimals array (zero based)
                ourAnimals[petCount, 0] = "ID #: " + animalID;
                ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                ourAnimals[petCount, 2] = "Age: " + animalAge;
                ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                // increment petCount (the array is zero-based, so we increment the counter after adding to the array)
                petCount = petCount + 1;

                // check maxPet limit
                if (petCount < maxPets)
                {
                    // another pet?
                    Console.WriteLine("Do you want to enter info for another pet (y/n)");
                    do
                    {
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            anotherPet = readResult.ToLower();
                        }

                    } while (anotherPet != "y" && anotherPet != "n");
                }
                //NOTE: The value of anotherPet (either "y" or "n") is evaluated in the while statement expression - at the top of the while loop
            }

            if (petCount >= maxPets)
            {
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                Console.WriteLine("Press the Enter key to continue.");
                readResult = Console.ReadLine();
            }

            break;

        case "3":
            // Ensure animal ages and physical descriptions are complete
            bool isComplete = false;
            
            do{// do loop until all ages and descriptions are assigned
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ") //if animal exist in array
                {
                    Console.WriteLine();
                    for (int j = 0; j < 6; j++) //inner loop for characteristics of animals
                    {
                        if ((ourAnimals[i, 2] == "Age: ") || (ourAnimals[i, 2] == "Age: ?"))//if there are no assigned age
                        {
                            Console.WriteLine($"Animal with {ourAnimals[i,0]} doesn't have valid age information. Please enter a pet's age:");
                            readResult = Console.ReadLine();
                            if(int.TryParse(readResult, out petAge)) //if users input is a valid integer
                            {
                                ourAnimals[i, 2] = "Age: " + readResult; // Update the age value
                                isComplete = true;
                            }
                            else
                            {
                                Console.WriteLine("Please input a valid integer!");
                            }
                            
                        }

                        else if (ourAnimals[i, 4] == "Physical description: ") 
                        {   isComplete = false;
                            Console.WriteLine($"Animal with {ourAnimals[i, 0]} doesn't have a physical description. Please provide a physical description (size, color, breed, gender, weight, housebroken)");
                            readResult = Console.ReadLine();
                            if(!string.IsNullOrWhiteSpace(readResult))//checks for valid input from user
                            {
                            ourAnimals[i, 4] = "Physical description: " + readResult;
                            isComplete = true;   
                            }

                        }
                        else
                        {
                            Console.WriteLine(ourAnimals[i, j].ToString());
                        }

                        }
                    }
                    // Check if the required entries are valid now
                    if (ourAnimals[i, 2] == "Age: " || ourAnimals[i, 4] == "Physical description: ")
                    {
                        isComplete = false; // Mark as incomplete if any of the required entries are still missing
                    }
                }
            }
            while (isComplete == false);
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "4": //option to add animal nickname or personality details
do
        {
            isComplete = true; // Assume the loop will complete unless we find invalid inputs.

            
            for (int i = 0; i < maxPets; i++) //loop for all animals
            {
                if (ourAnimals[i, 0] != "ID #: ") //if animal got existing ID
                {
                    Console.WriteLine();
                    
                    for (int j = 0; j < 6; j++) // loop for animal characteristics
                    {
                        if (ourAnimals[i, 3] == "Nickname: ") //if nickname blank
                        {
                            Console.WriteLine($"Animal with {ourAnimals[i, 0]} doesn't have a valid nickname. Please enter a pet's nickname:");
                            readResult = Console.ReadLine();
                            
                            if (!string.IsNullOrWhiteSpace(readResult)) //checks if result is not empty or null
                            {
                                ourAnimals[i, 3] = "Nickname: " + readResult;//assign a user input to nicname variable
                            }

                        }
                        else if (ourAnimals[i, 5] == "Personality: ")
                        {
                            Console.WriteLine($"Animal with {ourAnimals[i, 0]} doesn't have a personality description. Enter a personality description (likes or dislikes, tricks, energy level):");
                            readResult = Console.ReadLine();
                            
                            if (!string.IsNullOrWhiteSpace(readResult))
                            {
                                ourAnimals[i, 5] = "Personality: " + readResult;
                            }
                        }
                        else
                        {
                            Console.WriteLine(ourAnimals[i, j].ToString());
                        }
                    }
                    
                    // Check if the required entries are valid now.
                    if (ourAnimals[i, 3] == "Nickname: " || ourAnimals[i, 5] == "Personality: ")
                    {
                        isComplete = false; // Mark as incomplete if any of the required entries are still missing.
                    }
                }
            }
        }
        while (!isComplete);
    
    Console.WriteLine("Press the Enter key to continue.");
    Console.ReadLine();
    break;

        case "5":
            // Edit an animal’s age");
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "6":
            // Edit an animal’s personality description");
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "7":
            // Display all cats with a specified characteristic
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "8":
            // Display all dogs with a specified characteristic
            string dogCharacteristic = "";
            string dogDescription = "";
            bool noMatchesDog = true;
        
            while (dogCharacteristic == "")
            {
                // have the user enter physical characteristics to search for
                Console.WriteLine($"\nEnter one desired dog characteristics to search for");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    dogCharacteristic = readResult.ToLower().Trim();
                }
            } 
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 1].Contains("dog"))
                {
                    // #7 Search combined descriptions and report results
                    dogDescription = ourAnimals[i, 4] + "\n" + ourAnimals[i, 5];
                    if (dogDescription.Contains(dogCharacteristic))
                    {
                        Console.WriteLine($"\n\nOur dog {ourAnimals[i, 3]} is a match!");
                        Console.WriteLine(dogDescription);
                        noMatchesDog = false;
                    }
                }
            }
            if (noMatchesDog)
            {
                Console.WriteLine("None of our dogs are a match found for: " + dogCharacteristic);
            }
            break;

        default:
            break;
    }

} while (menuSelection != "exit");
