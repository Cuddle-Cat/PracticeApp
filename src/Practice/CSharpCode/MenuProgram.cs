using System;

class MenuProgram
{
    public static void Run()
    {
        int choice = 0;

        while (choice != 3)
        {
            Console.WriteLine("\n1. Add");
            Console.WriteLine("2. Multiply");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1 || choice == 2)
            {
                Console.Write("Enter first number: ");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                int y = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine($"Result: {x + y}");
                }
                else
                {
                    Console.WriteLine($"Result: {x * y}");
                }
            }
            else if (choice == 3)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}
