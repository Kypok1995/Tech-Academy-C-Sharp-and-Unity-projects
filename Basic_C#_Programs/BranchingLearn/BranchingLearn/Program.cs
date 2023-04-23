using System;

namespace BranchingLearn
{
    class Package
    {
        void PackageQuote()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter weight of your package"); // to check a weight
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day!");
                return;
            }

            Console.WriteLine("Please enter width of your package"); //for package width
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter height of your package"); //for package height
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter length of your package"); //for package length
            int packageLength = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50 || packageLength > 50 || packageHeight > 50) //checks if package is eligeble for shipping
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            float packageShipCost = (packageHeight * packageLength * packageWidth) * packageWeight / 100; //to calculate shipping cost

            Console.WriteLine("Your estimated total for shipping this package is: $" + packageShipCost); //to write shipping cost
        }

        static void Main(string[] args)
        {
            var package = new Package();
            package.PackageQuote();
        }
    }
}
