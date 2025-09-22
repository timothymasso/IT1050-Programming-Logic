using System;

class Program
{
    static double CylinderVolume(double radius, double height)
    {
        double cylVolume;
        cylVolume = 3.14 * radius * radius * height;
        return cylVolume;
    }

    static void Main(string[] args)
    {
        double radius;
        double height;
        double volume;

        Console.Write("Enter the radius of the cylinder: ");
        radius = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the cylinder: ");
        height = Convert.ToDouble(Console.ReadLine());

        volume = CylinderVolume(radius, height);

        Console.WriteLine("The volume of the cylinder is: " + volume);
    }
}