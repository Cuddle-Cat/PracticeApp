using System;

class AtmSimulator
{
    public static void Run()
    {
        decimal balance = 0m;
        int option = 0;
        while (option != 4)
        {
            Console.WriteLine("\n1.View Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine($"Current Balance: {balance:C}");
                    break;
                case 2:
                    Console.Write("Amount to deposit: ");
                    decimal deposit = Convert.ToDecimal(Console.ReadLine());
                    if (deposit > 0)
                    {
                        balance += deposit;
                        Console.WriteLine("Deposit successful!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount. Please enter a positive value.");
                    }
                    break;
                case 3:
                    Console.Write("Amount to withdraw:");
                    decimal withdraw = Convert.ToDecimal(Console.ReadLine());
                    if (withdraw <= 0)
                    {
                        Console.WriteLine("Invalid amount.");
                    }
                    else if (withdraw > balance)
                    {
                        Console.WriteLine("Insufficient Funds.");
                    }
                    else
                    {
                        balance -= withdraw;
                        Console.WriteLine("Withdrawal successful!");
                    }
                    break;
                case 4:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
