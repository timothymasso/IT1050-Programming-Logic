using System;

namespace ParkingCalculator
{
    class Program
    {
        // Function to calculate parking cost
        static double CalculateParkingCost(int hours)
        {
            double totalCost = 2.0;

            if (hours > 3)
            {
                totalCost += (hours - 3) * 0.5;
            }

            if (totalCost > 10.0)
            {
                totalCost = 10.0;
            }

            return totalCost;
        }

        static void Main(string[] args)
        {
            int numCustomers;
            int hours;
            double totalCost;

            Console.Write("Enter number of customers: ");
            numCustomers = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numCustomers; i++)
            {
                Console.Write($"Enter hours parked for customer {i}: ");
                hours = Convert.ToInt32(Console.ReadLine());

                totalCost = CalculateParkingCost(hours);

                Console.WriteLine($"Total parking cost for customer {i}: ${totalCost:F2}\n");
            }
        }
    }
}