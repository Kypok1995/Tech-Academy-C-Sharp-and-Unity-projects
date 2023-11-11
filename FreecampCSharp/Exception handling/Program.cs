

// Prompt the user for the lower and upper bounds
Console.Write("Enter the lower bound: ");
int lowerBound = int.Parse(Console.ReadLine());

Console.Write("Enter the upper bound: ");
int upperBound = int.Parse(Console.ReadLine());

decimal averageValue = 0;
bool shouldExit = false; //bol variable to set condition for do while loop
do
{
    try
    {
        // Calculate the sum of the even numbers between the bounds
        averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

        // Display the value returned by AverageOfEvenNumbers in the console
        Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");
        shouldExit = true;//breaks a loop 
    }

    catch (ArgumentOutOfRangeException ex) //catches an exception inside do while loop until user not promted valid bound or exits program
    {
        Console.WriteLine($"The upper bound {upperBound} must be greater than {lowerBound}");
        Console.Write("Enter a new upper bound (or enter Exit to quit): ");
        string? answer = Console.ReadLine();
        if (answer.ToLower().Trim().Contains("exit")) //simple check for user answer
        {
            shouldExit = true; //breaks a loop
        }
        else
        {
            upperBound = int.Parse(answer); //check for valid integer
        }
    }
} while (shouldExit == false); 

// Wait for user input
Console.ReadLine();

static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)//method for calculating sum of even numbers between two bounds
{
    if (lowerBound >= upperBound) // check for exception before start of calculations
    {
        throw new ArgumentOutOfRangeException("upperBound", "ArgumentOutOfRangeException: upper bound must be greater than lower bound.");
    }


    int sum = 0;
    int count = 0;
    decimal average = 0;

    for (int i = lowerBound; i <= upperBound; i++)
    {
        if (i % 2 == 0)
        {
            sum += i;
            count++;
        }
    }

    average = (decimal)sum / count;

    return average;
}

  
  
 
