using System;

class TicketFine
{
    private const decimal COST_PER_5 = 87.50m;

    public int SpeedLimit { get; set; }
    public int ReportedSpeed { get; set; }
    public char Classification { get; set; }
    public decimal Fine { get; private set; }

    public void CalculateFine()
    {
        int over = ReportedSpeed - SpeedLimit;

        if (over <= 0)
        {
            Fine = 0m;
            return;
        }

        // Base fine: $75 + 87.50 per each 5 MPH over
        decimal baseFine = (over / 5) * COST_PER_5 + 75.00m;
        decimal finalFine = baseFine;

        if (Classification == '4')
        {
            if (over > 20)
                finalFine += 200.00m;
            else
                finalFine += 50m;
        }
        else if (Classification == '1')
        {
            if (over < 21)
                finalFine -= 50m;
            else
                finalFine -= 100m;
        }
        else
        {
            if (over > 20)
                finalFine += 100m;
        }

        Fine = finalFine;
    }

    // This allows the Menu.cs option 13 to work
    public static void Run()
    {
        TicketFine t = new TicketFine();

        Console.Write("Enter the speed limit: ");
        t.SpeedLimit = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter reported speed: ");
        t.ReportedSpeed = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter classification (1, 4, or other): ");
        t.Classification = Convert.ToChar(Console.ReadLine());

        t.CalculateFine();

        Console.WriteLine($"\nCalculated Fine: {t.Fine:C}");
    }
}
