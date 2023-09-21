using System;

class SampleReport
{
    public void DailyReport()
    {
        Console.WriteLine("What is your name?");
        string studentName = Console.ReadLine(); //to store student name

        Console.WriteLine("What course are you on?");
        string studentCourse = Console.ReadLine();// student course

        Console.WriteLine("What is your current page number in your course?");
        string studentPage = Console.ReadLine();
        int studentPageNumber = Convert.ToInt32(studentPage); // to convert page number into int

        Console.WriteLine("Do you need help with anything? Please answer \u0022true\u0022 or \u0022false\u0022.");
        string studentAnswer = Console.ReadLine();
        bool studentAnswerBool = Convert.ToBoolean(studentAnswer); //to convert answer into bool

        Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
        string studentExperience = Console.ReadLine(); // to store student experience

        Console.WriteLine("Is there any other feedback you would like to provide? Please be specific.");
        string studentFeedback = Console.ReadLine(); //to store student's feedback

        Console.WriteLine("How many hours did you study today?");
        string studentHours = Console.ReadLine();
        int studentHoursInt = Convert.ToInt32(studentHours); //convert answer into int

        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day! \nIf you would like to check results of your Daily Report pleese type \u0022yes\u0022 or \u0022no\u0022. ");
        string studentDailyConsent = Console.ReadLine();

        if (studentDailyConsent.ToUpper() == "YES"){
            Console.WriteLine("Student's name: " + studentName + "\nStudent's course: " + studentCourse + 
            "\nPage number in the course is: " + studentPageNumber + "\nStudent need help true/false: " + studentAnswerBool
            + "\nStudent would like to share experience about: " + studentExperience
            + "\nStudent would like to share following feedback: " +studentFeedback
            + "\nStudent study following amount of hours this week: " +studentHoursInt);
              
        }
        else if (studentDailyConsent.ToUpper() == "NO"){
            Console.WriteLine("Have a good day!");
        }

    }

	static void Main()
    {
        Console.WriteLine("The Tech Academy \nStudent Daily Report.\n");

        var student = new SampleReport();
        student.DailyReport();


    }
}