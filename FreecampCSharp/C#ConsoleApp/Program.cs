Random dice = new Random(); //new instance of random class

int roll1 = dice.Next(1, 7); //to save amount between 1 and 6
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);


int total = roll1 + roll2 + roll3; // to save total of three rolls

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}"); //output result




if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) // check if there are any matches in dices
{
    if ((roll1 == roll2) && (roll2 == roll3)) //if 3 dices equal - 6 points bonus
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else //just two dices equal - 2 points bonus
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

if (total >= 16) //win logic, got different presents for different 
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}

