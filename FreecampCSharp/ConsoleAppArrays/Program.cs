using System.Xml.Linq;


int currentAssignments = 5; //amount of assignments

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 }; //arrays with student scores for all assignments
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };


string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };//array for holding all students names
int[] studentScores = new int[10]; //array to hold up to 10 scores for exact student
string currentStudentLetterGrade = ""; //blank variable for student grade letter


Console.WriteLine("Student\t\tExam Score\tOverall Grade \t\tExtra Credit\n");
foreach (string studentName in studentNames) {
    string currentStudent = studentName;//variable to hold current student name
    decimal sumAssignmentScores = 0;
    decimal totalExamScore;
    decimal currentStudentGrade;
    decimal totalExtraCredit;
    decimal additionalPoints;

    if (currentStudent == "Sophia")
    {
        studentScores = sophiaScores;// assign scores of exact student for foreach loop
    }

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    else if (currentStudent == "Becky")
        studentScores = beckyScores;
    else if (currentStudent == "Chris")
        studentScores = chrisScores;
    else if (currentStudent == "Eric")
        studentScores = ericScores;
    else if (currentStudent == "Gregor")
        studentScores = gregorScores;
    else
        continue;

    // initialize/reset a counter for the number of assignments
    int gradedAssignments = 0;
    
    decimal examScore = 0;
    decimal extraCredit = 0;
    
    foreach (int score in studentScores)//calculate scores
    {
        gradedAssignments++;
        if (gradedAssignments <= currentAssignments){
            examScore+=score; //to calculate only exam scores
            // add the exam score to the sum
            sumAssignmentScores += score;}
        else{
            // add the extra credit points to the sum - bonus points equal to 10% of an exam score
            extraCredit+=score; //to calculate scores for extra credits
            sumAssignmentScores += (decimal)score / 10;
        }

    }
    totalExtraCredit = (decimal)extraCredit / (gradedAssignments - currentAssignments); //to calculate extra credit point earned
    totalExamScore = (decimal)examScore/currentAssignments;//to calculate exam score without additional credits
    currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments;//to calculate overall GPA of student
    additionalPoints = currentStudentGrade - totalExamScore;



    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";



    Console.WriteLine($"{currentStudent}\t\t{totalExamScore}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t\t{totalExtraCredit} ({additionalPoints} pts)");
}


Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
