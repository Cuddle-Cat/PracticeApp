using System;
using System.Collections;

class Menu
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("===== MAIN MENU =====");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Run Variables Example");
            Console.WriteLine("2. Run Basic Math");
            Console.WriteLine("3. Run Age Calculator");
            Console.WriteLine("4. Even or Odd Checker");
            Console.WriteLine("5. Max of Three");
            Console.WriteLine("6. Grade Converter");
            Console.WriteLine("7. Menu Program");
            Console.WriteLine("8. Reverse String");
            Console.WriteLine("9. Run Vowel Counter");
            Console.WriteLine("10. ATM Simulator");
            Console.WriteLine("11. Class Car");
            Console.WriteLine("12. Bank Account");
            Console.WriteLine("13. Ticket Fine Calculator");
            Console.WriteLine("14. Arrays Practice");
            Console.Write("Choose an option: ");

            string? choice = Console.ReadLine();
            Console.WriteLine(); // spacing

            switch (choice)
            {
                case "0":
                    Console.WriteLine("Goodbye!");
                    return;

                case "1":
                    VariablesExample.Run();
                    Pause();
                    break;

                case "2":
                    BasicMath.MathBasic();
                    Pause();
                    break;

                case "3":
                    AgeCalculator.CalculateAge();
                    Pause();
                    break;

                case "4":
                    EvenOrOdd.Run();
                    Pause();
                    break;

                case "5":
                    MaxOfThree.Run();
                    Pause();
                    break;

                case "6":
                    GradeConverter.Run();
                    Pause();
                    break;

                case "7":
                    MenuProgram.Run();
                    Pause();
                    break;

                case "8":
                    ReverseString.Run();
                    Pause();
                    break;

                case "9":
                    VowelCounter.Run();
                    Pause();
                    break;

                case "10":
                    AtmSimulator.Run();
                    Pause();
                    break;

                case "11":
                    ClassCar.Run();
                    Pause();
                    break;

                case "12":
                    BankAccount.Run();
                    Pause();
                    break;

                case "13":
                    TicketFine.Run();
                    Pause();
                    break;

                case "14":
                    ArraysPractice.Run();
                    Pause();
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }

            Console.WriteLine(); // extra spacing after option runs
        }
    }

    static void Pause()
    {
        Console.WriteLine();
        Console.WriteLine("Press ENTER to return to the menu...");
        Console.ReadLine();
        Console.Clear(); // Clears screen for cleaner look
    }
}
