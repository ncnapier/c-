using System;

// initialize variables - graded assignments 
int examAssignments = 5;
int examScore = 0;
int extraCredit = 0;
int[] sophiaScores = new int[] {90, 86, 87, 98, 100, 94, 90};
int[] andrewScores = new int[] {92, 89, 81, 96, 90, 89};
int[] emmaScores = new int[] {90, 85, 87, 98, 68, 89, 89, 89};
int[] loganScores = new int[] {90, 95, 87, 88, 96, 96};

string[] studentNames = new string[] {"Sophia", "Andrew", "Emma", "Logan"};

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tExam Score\t\tOverall Grade\t\t Extra Credit\n");

foreach (string name in studentNames)
{
    string currentStudent = name;
    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;
    
        int sumAssignmentScores = 0;

        decimal currentStudentGrade = 0;

// initialize/ reset a counter for the number of assignments
    int gradedAssignments = 0;

    foreach (int score in studentScores)
    {
    //increment the assignment counter
    gradedAssignments += 1;
    if (gradedAssignments <= examAssignments)
        sumAssignmentScores += score;
    else
        sumAssignmentScores += score / 10;
   
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

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
else    
    currentStudentLetterGrade = "F";


    Console.WriteLine($"{currentStudent}\t\t{examScore}\t\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t\t{extraCredit}");
    
}



Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

