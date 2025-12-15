using System;

class BankAccount
{
    public string Owner { get; private set; }
    public decimal Balance { get; private set; }

    public BankAccount(string owner, decimal initialBalance = 0.0m)
    {
        Owner = owner;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be positive.");
            return;
        }

        Balance += amount;
        Console.WriteLine($"{Owner} deposited {amount:C}. New balance: {Balance:C}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal amount must be positive.");
            return;
        }

        if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds for withdrawal.");
            return;
        }

        Balance -= amount;
        Console.WriteLine($"{Owner} withdrew {amount:C}. New balance: {Balance:C}");
    }

    public void TransferTo(BankAccount other, decimal amount)
    {
        if (other == null)
        {
            Console.WriteLine("Transfer to a null account is not allowed.");
            return;
        }

        if (amount <= 0)
        {
            Console.WriteLine("Transfer amount must be positive.");
            return;
        }

        if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds for transfer.");
            return;
        }

        Balance -= amount;
        other.Balance += amount;

        Console.WriteLine($"Transferred {amount:C} from {Owner} to {other.Owner}.");
    }

    public static void Run()
    {
        // Demo accounts
        BankAccount a = new BankAccount("Alice", 1000.0m);
        BankAccount b = new BankAccount("Bob", 500.0m);
        BankAccount c = new BankAccount("Charlie");

        a.Deposit(500.0m);
        a.Withdraw(200.0m);
        a.TransferTo(b, 300.0m);

        Console.WriteLine("\nFinal Balances:");
        Console.WriteLine($"{a.Owner}'s balance: {a.Balance:C}");
        Console.WriteLine($"{b.Owner}'s balance: {b.Balance:C}");
        Console.WriteLine($"{c.Owner}'s balance: {c.Balance:C}");
    }
}
