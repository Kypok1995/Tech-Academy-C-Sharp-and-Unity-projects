using System;
using System.IO;

namespace IO_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input any number you like!");
            string text = Console.ReadLine();
            using (StreamWriter writer = new StreamWriter(@"C:\Users\Andrei\Documents\GitHub\Tech-Academy-C-Sharp-and-Unity-projects\Basic_C#_Programs\IO assignment\file.txt", true))//create steamwriter to print a text in the fle
            {
                writer.WriteLine(text);
            }
            string readText = File.ReadAllText(@"C:\Users\Andrei\Documents\GitHub\Tech-Academy-C-Sharp-and-Unity-projects\Basic_C#_Programs\IO assignment\file.txt");
            Console.WriteLine("The number you written is: " + readText);


        }
    }
}
