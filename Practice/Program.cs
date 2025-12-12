// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         string playerName = "Luis";
//         int level = 5;
//         double health = 92.5;
//         bool isAlive = true;

//         Console.WriteLine(
//             $"Player: {playerName}, Level: {level}, Health: {health}, Alive: {isAlive}"
//         );
//     }
// }

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter number 1: ");
//         int num1 = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Enter number 2: ");
//         int num2 = Convert.ToInt32(Console.ReadLine());
//         int sum = num1 + num2;
//         int diff = num1 - num2;
//         int prod = num1 * num2;
//         double quot = (double)num1 / num2;
//         Console.WriteLine($"Sum: {sum}");
//         Console.WriteLine($"Difference: {diff}");
//         Console.WriteLine($"Product: {prod}");
//         Console.WriteLine($"Quotient: {quot}");
//     }
// }

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter birth year: ");
//         int birthYear = Convert.ToInt32(Console.ReadLine());
//         int currentYear = 2025;
//         int age = currentYear - birthYear;
//         Console.WriteLine($"You are {age} years old.");
//     }
// }
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter a number: ");
//         int number = Convert.ToInt32(Console.ReadLine());
//         if (number % 2 == 0)
//         {
//             Console.WriteLine("The number is even.");
//         }
//         else
//         {
//             Console.WriteLine("The number is odd.");
//         }
//     }
// }
//
//
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter number 1: ");
//         int a = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Enter number 2: ");
//         int b = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Enter number 3: ");
//         int c = Convert.ToInt32(Console.ReadLine());
//         int largest = a;
//         if (b > largest)
//         {
//             largest = b;
//         }
//         if (c > largest)
//         {
//             largest = c;
//         }
//         Console.WriteLine($"The largest number is: {largest}");
//     }
// }
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter score (0-100): ");
//         int score = Convert.ToInt32(Console.ReadLine());
//         string grade;
//         if (score >= 90)
//         {
//             grade = "A";
//         }
//         else if (score >= 80)
//         {
//             grade = "B";
//         }
//         else if (score >= 70)
//         {
//             grade = "C";
//         }
//         else if (score >= 60)
//         {
//             grade = "D";
//         }
//         else
//         {
//             grade = "F";
//         }
//         Console.WriteLine($"Your grade is: {grade}");
//     }
// }

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int choice = 0;
//         while (choice != 3)
//         {
//             Console.WriteLine("\n1. Add");
//             Console.WriteLine("2. Multiply");
//             Console.WriteLine("3. Exit");
//             Console.Write("Choose an option: ");
//             choice = Convert.ToInt32(Console.ReadLine());
//             if (choice == 1 || choice == 2)
//             {
//                 Console.Write("Enter First Number: ");
//                 int x = Convert.ToInt32(Console.ReadLine());
//                 Console.Write("Enter Second Number: ");
//                 int y = Convert.ToInt32(Console.ReadLine());
//                 if (choice == 1)
//                 {
//                     Console.WriteLine($"Result: {x + y}");
//                 }
//                 else if (choice == 2)
//                 {
//                     Console.WriteLine($"Result: {x * y}");
//                 }
//             }
//             else if (choice == 3)
//             {
//                 Console.WriteLine("Exiting...");
//             }
//             else
//             {
//                 Console.WriteLine("Invalid option. Please try again.");
//             }
//         }
//     }
// }

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter a word:");
//         string input = Console.ReadLine();
//         string reversed = "";
//         for (int i = input.Length - 1; i >= 0; i--)
//         {
//             reversed += input[i];
//         }
//         Console.WriteLine($"Reversed word: {reversed}");
//     }
// }
// Program.cs
// Program.cs
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Run the variables example first
//         VariablesExample.Run();

//         // Then run the vowel counter
//         CountVowels();
//     }

//     // New method for your vowel-counting logic
//     static void CountVowels()
//     {
//         Console.Write("Enter a sentence: ");

//         // Read input and handle the case where it might be null
//         string? input = Console.ReadLine();

//         if (string.IsNullOrEmpty(input))
//         {
//             Console.WriteLine("No text entered.");
//             return;
//         }

//         string text = input.ToLower();
//         int vowelCount = 0;

//         foreach (char ch in text)
//         {
//             if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
//             {
//                 vowelCount++;
//             }
//         }

//         Console.WriteLine($"Number of vowels: {vowelCount}");
//     }
// }

