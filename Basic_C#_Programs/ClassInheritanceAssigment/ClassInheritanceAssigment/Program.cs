using System;
using System.Collections.Generic;

namespace ClassInheritanceAssigment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new() { FirstName = "Sample", LastName = "Student" }; //Inside of the Main method, instantiate and initialize an Employee object with a first name of “Sample” and a last name of “Student
            employee.SayName(); //Call the superclass method SayName() on the Employee object.

            IQuittable employee2 = new Employee<string> {FirstName = "Andrei", LastName = "Trubitsyn" }; //create an object of type IQuittable and call the Quit() method on it
            employee2.Quit();

            Employee<string> employee3 = new() { FirstName = "Anastasiia", LastName = "Logunova", id = 228 }; //test employees for operator overloading
            Employee<string> employee4 = new() { FirstName = "Jigan", LastName = "Lemon", id = 48 };
            Employee<string> employee5 = new() { FirstName = "Nastya", LastName = "Logunoza", id = 228 };

            Console.WriteLine(employee3 == employee5); // this shows implementation of overloaded operator ==
            Console.WriteLine(employee3 != employee4); //this shows implementation of overloaded operator !=

            Employee<string> employee6 = new() { FirstName = "Generic", LastName = "Class" }; //Instantiate an Employee object with type “string” as its generic parameter. 
            employee6.Things = new List<string> { "Workspace", "Laptop", "Office pen", "Chair" }; //Assign a list of strings as the property value of Things.

            Employee<int> employee7 = new() { FirstName = "Complicated", LastName = "Assignment" };// Instantiate an Employee object with type “int” as its generic parameter. 
            employee7.Things = new List<int> { 228, 59, 41, 4151 }; //Assign a list of integers as the property value of Things.

            Console.WriteLine("Employee 1 Things:"); 
            foreach (string thing in employee6.Things) //loop to print employee 6 Things
            {
                Console.WriteLine(thing);
            }

            Console.WriteLine("\nEmployee 2 Things:");
            foreach (int thing in employee7.Things) //loop to print employee 7 Things
            {
                Console.WriteLine(thing);
            }
        }
    }
}
