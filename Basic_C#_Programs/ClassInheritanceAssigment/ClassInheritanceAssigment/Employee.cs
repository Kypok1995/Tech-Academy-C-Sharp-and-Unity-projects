using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritanceAssigment
{
    public class Employee: Person, IQuittable //Create another class called Employee and have it inherit from the Person class. Give the Employee class a property called Id and have it be of data type int.
    {
        public int id { get; set; }

        public override void SayName() //here is implementation for abstact method from abstract class Person
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        public void Quit() //Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose
        {
            Console.WriteLine("All right, that's enough for me!! I, " + FirstName + " " + LastName + " , leaving this job at " + DateTime.Now);
        }

    }
}
