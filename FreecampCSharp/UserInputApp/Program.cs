// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;

    case "02":
        type = "T-Shirt";
        break;

    case "03":
        type = "Sweat pants";
        break;

    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;

    case "MN":
        color = "Maroon";
        break;

    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;

    case "M":
        size = "Medium";
        break;

    case "L":
        size = "Large";
        break;

    default:
        size = "One size fits all";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");



//while loop usage
Random randomPlayer = new Random();
int playerHP = 10;

Random randomEnemy = new Random();
int enemyHP = 10;

while (playerHP > 0 && enemyHP > 0)
{
    int playerHit = randomPlayer.Next(1, 11);
    int enemyHit = randomEnemy.Next(1, 11);

    enemyHP -= playerHit;
    Console.WriteLine($"Player hit a enemy for {playerHit} damage, enemy HP now is {enemyHP}");
    if (enemyHP <= 0)
    {
        Console.WriteLine("Player wins!");
        break;
    }


    playerHP -= enemyHit;
    Console.WriteLine($"Enemy hit a player for {enemyHit} damage, player HP now is {playerHP}");

    if (playerHP <= 0)
    {
        Console.WriteLine("Enemy wins!");
        break;
    }



}


//Code for validating integer input
bool isValidInt = false;

while (isValidInt == false)
{
    Console.WriteLine("Input an integer between 5 and 10");

    string numberString = Console.ReadLine();
    if (int.TryParse(numberString, out int number))
    {
        if (number > 5 && number < 10)
        {
            Console.WriteLine($"Your number is {number} and it is between 5 and 10");
            isValidInt = true;
            break;
        }
        Console.WriteLine($"Integer {number} is not between 5 and 10");
    }
    else
    {
        Console.WriteLine("The input string is not a valid integer.");
    }
}


//code to verify string input       
Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

bool isValid = false;

while (isValid == false)
{

    string input = Console.ReadLine();

    string cleanInput = input.Trim().ToLower();

    if (cleanInput == "administrator" || cleanInput == "user"){
        Console.WriteLine($"Your input ({cleanInput}) has been accepted");
        isValid = true;
        break;
    }
    else
    {
        Console.WriteLine($"The role name that you entered,{input}  is not valid. Enter your role name (Administrator, Manager, or User)");
    }
}


