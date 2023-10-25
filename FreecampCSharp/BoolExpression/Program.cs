Console.WriteLine("Write your role");
string permission = Console.ReadLine();
Console.WriteLine("Write your level");
string levelText = Console.ReadLine();
int level = int.Parse(levelText); //to convert into string

if (permission.ToLower().Contains("admin")) //checks for admin role
{
    string greetingAdmin = level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user."; //ternary operator with 2 strings outputs
    Console.WriteLine(greetingAdmin);
}

else if (permission.ToLower().Contains("manager"))
{
    string greetingManager = level > 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.";
    Console.WriteLine(greetingManager);
}

else
{
    Console.WriteLine("You do not have sufficient privileges.");
}