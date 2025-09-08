using System;

class Program
{
    static void Main()
    {
        string name;
        double salesAmount;
        double commission;
        string performanceStatus;

        Console.Write("Enter name of salesperson: ");
        name = Console.ReadLine();

        Console.Write("Enter sales amount: ");
        salesAmount = Convert.ToDouble(Console.ReadLine());

        commission = 200 + (.09 * salesAmount);

        if (salesAmount >= 15000)
        {
            performanceStatus = "Outstanding";
        }
        else if (salesAmount >= 10000)
        {
            performanceStatus = "Excellent";
        }
        else if (salesAmount >= 5000)
        {
            performanceStatus = "Good";
        }
        else if (salesAmount >= 3000)
        {
            performanceStatus = "Average";
        }
        else
        {
            performanceStatus = "Poor";
        }

        Console.WriteLine("\nName of item: " + name);
        Console.WriteLine("Sales amount: $" + salesAmount);
        Console.WriteLine("Commission: $" + Math.Round(commission, 2));
        Console.WriteLine("Performance status: " + performanceStatus);
    }
}


