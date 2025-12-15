using System;

class GradeConverter
{
    public static void Run()
    {
        Console.WriteLine("Enter Score (0-100):");
        int score = Convert.ToInt32(Console.ReadLine());
        string grade;
        if (score >= 90)
        {
            grade = "A";
        }
        else if (score >= 80)
        {
            grade = "B";
        }
        else if (score >= 70)
        {
            grade = "C";
        }
        else if (score >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }
        Console.WriteLine($"Your grade is: {grade}");
    }
}
