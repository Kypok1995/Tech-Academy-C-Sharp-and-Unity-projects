using System;

namespace ClassInheritanceAssigment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" }; //Inside of the Main method, instantiate and initialize an Employee object with a first name of “Sample” and a last name of “Student
            employee.SayName(); //Call the superclass method SayName() on the Employee object.

            IQuittable employee2 = new Employee() {FirstName = "Andrei", LastName = "Trubitsyn" }; //create an object of type IQuittable and call the Quit() method on it
            employee2.Quit();

            Employee employee3 = new Employee() { FirstName = "Anastasiia", LastName = "Logunova", id = 228 };
            Employee employee4 = new Employee() { FirstName = "Jigan", LastName = "Lemon", id = 48 };
            Employee employee5 = new Employee() { FirstName = "Nastya", LastName = "Logunoza", id = 228 };

            Console.WriteLine(employee3 == employee5); // this shows implementation of overloaded operator ==
            Console.WriteLine(employee3 != employee4); //this shows implementation of overloaded operator !=
        }
    }
}
