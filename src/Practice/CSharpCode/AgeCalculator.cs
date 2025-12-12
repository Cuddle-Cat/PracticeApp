using System;

class AgeCalculator
{
    public static void CalculateAge()
    {
        Console.Write("Enter birth year: ");
        int birthYear = Convert.ToInt32(Console.ReadLine());
        int currentYear = 2025;
        int age = currentYear - birthYear;
        Console.WriteLine($"You are {age} years old.");
    }
}