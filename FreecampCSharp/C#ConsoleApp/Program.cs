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


Random random = new Random(); // new random instance for second part of the assignment
int daysUntilExpiration = random.Next(12); // program below should show different messages depending on amount of days before expiration
int discountPercentage = 0;

daysUntilExpiration = 0;

if (daysUntilExpiration <= 10 && daysUntilExpiration > 5){
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if(daysUntilExpiration <=5 && daysUntilExpiration > 1){
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save 10%!");
}

else if(daysUntilExpiration ==1){
    Console.WriteLine("Your subscription expires within a day!\nRenew now and save 20%!");
}

else if(daysUntilExpiration ==0){
    Console.WriteLine("Your subscription has expired.");
}


string [] fraudulentOrders = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"}; //code for arrays assignment

foreach (string order in fraudulentOrders){
    
    if(order.StartsWith("B")){
        Console.WriteLine($"Possibly fraudulent order: {order}");
    }
}
