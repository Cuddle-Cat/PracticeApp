using System;

class VowelCounter
{
    public static void Run()
    {
        Console.Write("Enter a sentence: ");

        string? input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("No text entered.");
            return;
        }

        string text = input.ToLower();
        int vowelCount = 0;

        foreach (char ch in text)
        {
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                vowelCount++;
            }
        }

        Console.WriteLine($"Number of vowels: {vowelCount}");
    }
}

