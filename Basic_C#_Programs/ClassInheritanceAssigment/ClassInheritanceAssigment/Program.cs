using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassInheritanceAssigment
{
    class Program
    {
        static void Main(string[] args)
        {
            /*       Employee<string> employee = new Employee<string>() { FirstName = "Sample", LastName = "Student" }; //Inside of the Main method, instantiate and initialize an Employee object with a first name of “Sample” and a last name of “Student
                   employee.SayName(); //Call the superclass method SayName() on the Employee object.

                   IQuittable employee2 = new Employee<string> {FirstName = "Andrei", LastName = "Trubitsyn" }; //create an object of type IQuittable and call the Quit() method on it
                   employee2.Quit();

                   Employee<string> employee3 = new Employee<string>() { FirstName = "Anastasiia", LastName = "Logunova", id = 228 }; //test employees for operator overloading
                   Employee<string> employee4 = new Employee<string>() { FirstName = "Jigan", LastName = "Lemon", id = 48 };
                   Employee<string> employee5 = new Employee<string>() { FirstName = "Nastya", LastName = "Logunoza", id = 228 };

                   Console.WriteLine(employee3 == employee5); // this shows implementation of overloaded operator ==
                   Console.WriteLine(employee3 != employee4); //this shows implementation of overloaded operator !=

                   Employee<string> employee6 = new Employee<string>() { FirstName = "Generic", LastName = "Class" }; //Instantiate an Employee object with type “string” as its generic parameter. 
                   employee6.Things = new List<string> { "Workspace", "Laptop", "Office pen", "Chair" }; //Assign a list of strings as the property value of Things.

                   Employee<int> employee7 = new Employee<int>() { FirstName = "Complicated", LastName = "Assignment" };// Instantiate an Employee object with type “int” as its generic parameter. 
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
                   Console.ReadLine();*/

            List<Employee<string>> employeesList = new List<Employee<string>>();//create a list of at least 10 employees
            employeesList.Add(new Employee<string> { FirstName = "Joe", LastName = "Ogutu", id = 1 });
            employeesList.Add(new Employee<string> { FirstName = "Mark", LastName = "Spensor", id = 2 });
            employeesList.Add(new Employee<string> { FirstName = "Vin", LastName = "Diesel", id = 3 });
            employeesList.Add(new Employee<string> { FirstName = "Joe", LastName = "Swanson", id = 4 });
            employeesList.Add(new Employee<string> { FirstName = "Voldemar", LastName = "Pitun", id = 5 });
            employeesList.Add(new Employee<string> { FirstName = "Hugo", LastName = "Boss", id = 6 });
            employeesList.Add(new Employee<string> { FirstName = "Kirsten", LastName = "Danst", id = 7 });
            employeesList.Add(new Employee<string> { FirstName = "Lil", LastName = "Wayne", id = 8 });
            employeesList.Add(new Employee<string> { FirstName = "Coolio", LastName = "Gangsta", id = 9 });
            employeesList.Add(new Employee<string> { FirstName = "Benni", LastName = "Benassi", id = 10 });

            
            foreach (Employee<string> emp in employeesList) //Using a foreach loop, create a new list of all employees with the first name “Joe”
            {
                List<Employee<string>> employeeJoe = new List<Employee<string>>();
                if(emp.FirstName == "Joe")
                {
                    employeeJoe.Add(emp);
                    Console.WriteLine(emp.FirstName + " " +  emp.LastName);
                }
            }

            List<Employee<string>> filteredList = employeesList.Where(x => x.FirstName == "Joe").ToList(); //Perform the same action again, but this time with a lambda expression

            foreach(Employee<string> emp in filteredList) //to check if lambda expression works
            {
                Console.WriteLine(emp.FirstName + " " + emp.LastName);
            }

            List<Employee<string>> newFilteredList = employeesList.Where(x => x.id > 5).ToList(); //Using a lambda expression, make a list of all employees with an Id number greater than 5.

            foreach (Employee<string> emp in newFilteredList) //to check if second lambda working well
            {
                Console.WriteLine(emp.FirstName + " " + emp.LastName + " " + emp.id);
            }


        }
    }
}
