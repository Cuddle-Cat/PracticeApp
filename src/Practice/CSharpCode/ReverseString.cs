using System;

class ReverseString
{
    public static void Run()
    {
        Console.Write("Enter a Word: ");
        string input = Console.ReadLine();
        String reversed = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }
        Console.WriteLine("Reversed Word: " + reversed);
    }
}
