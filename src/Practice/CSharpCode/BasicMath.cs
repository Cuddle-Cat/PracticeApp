using System;

class BasicMath
{
    public static void MathBasic()
    {
        Console.Write("Enter number 1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number 2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int sum = num1 + num2;
        int diff = num1 - num2;
        int prod = num1 * num2;
        double quot = (double)num1 / num2;
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {diff}");
        Console.WriteLine($"Product: {prod}");
        Console.WriteLine($"Quotient: {quot}");
    }
}
