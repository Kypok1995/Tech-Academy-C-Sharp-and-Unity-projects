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
        }
    }
}
