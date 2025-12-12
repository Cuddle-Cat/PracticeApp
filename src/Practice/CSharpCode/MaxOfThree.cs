using System;

class MaxOfThree
{
    public static void Run()
    {
        Console.Write("Enter number 1: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number 2: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number 3: ");
        int c = Convert.ToInt32(Console.ReadLine());
        int largest = a;
        if (b > largest)
        {
            largest = b;
        }
        if (c > largest)
        {
            largest = c;
        }
        Console.WriteLine($"The largest number is: {largest}");
    }
}
