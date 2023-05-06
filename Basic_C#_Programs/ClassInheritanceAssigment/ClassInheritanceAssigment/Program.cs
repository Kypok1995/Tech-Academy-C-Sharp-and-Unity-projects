using System;

namespace ClassInheritanceAssigment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" }; //Inside of the Main method, instantiate and initialize an Employee object with a first name of “Sample” and a last name of “Student
            employee.SayName(); //Call the superclass method SayName() on the Employee object.
        }
    }
}
