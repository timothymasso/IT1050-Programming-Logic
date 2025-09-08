using System;

class Program
{
    static void Main()
    {
        double distance;
        int time;
        double speed;
        double totalSpeed = 0;
        int numCar;

        Console.Write("Enter how many cars to calculate the speed for:");
        numCar = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= numCar; i++)
        {
            Console.Write("\nEnter distance traveled by car " + i + " (in miles): ");
            distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter time taken by car " + i + " (hours): ");
            time = Convert.ToInt32(Console.ReadLine());

            speed = distance / (time);
            totalSpeed = totalSpeed + speed;

            Console.WriteLine("Speed of car " + i + ": " + Math.Round(speed, 2) + " mph");
        }

        double averageSpeed = totalSpeed / numCar;

        Console.WriteLine("\nAverage speed of all cars: " + averageSpeed + " mph");

    }
}
