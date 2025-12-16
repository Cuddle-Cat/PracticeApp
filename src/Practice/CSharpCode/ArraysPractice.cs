using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class ArraysPractice
{
    public static void Run()
    {
        int[] nums = { 5, 12, 7, 20, 3, 9 };
        Console.WriteLine($"Min: {Min(nums)}");
        Console.WriteLine($"Max: {Max(nums)}");
        Console.WriteLine($"Average: {Average(nums)}");
        int[] evens = GetEvens(nums);
        Console.WriteLine($"Evens: {string.Join(", ", evens)}");
    }

    static int Min(int[] arr)
    {
        int min = arr[0];
        foreach (int n in arr)
        {
            if (n < min)
                min = n;
        }
        return min;
    }

    static int Max(int[] arr)
    {
        int max = arr[0];
        foreach (int n in arr)
        {
            if (n > max)
                max = n;
        }
        return max;
    }

    static double Average(int[] arr)
    {
        int sum = 0;
        foreach (int n in arr)
        {
            sum += n;
        }
        return (double)sum / arr.Length;
    }

    static int[] GetEvens(int[] arr)
    {
        List<int> evens = new List<int>();
        foreach (int n in arr)
        {
            if (n % 2 == 0)
                evens.Add(n);
        }
        return evens.ToArray();
    }
}
