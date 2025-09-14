using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            string name;
            double height;
            double weight;
            double bmi;

            Console.Write("Enter name: ");
            name = Console.ReadLine();

            Console.Write("Enter height (in inches): ");
            height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter weight (in pounds): ");
            weight = Convert.ToDouble(Console.ReadLine());

            bmi = ((703 * weight) / (height * height));

            Console.WriteLine("\nName: " + name);
            Console.WriteLine("Height: " + height + " inches");
            Console.WriteLine("Weight: " + weight + " pounds");

            if (bmi < 18.5)
            {
                Console.WriteLine("BMI: " + Math.Round(bmi, 2) + "\nYou are Underweight");
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                Console.WriteLine("BMI: " + Math.Round(bmi, 2) + "\nYou have a Normal or Healthy weight");
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                Console.WriteLine("BMI: " + Math.Round(bmi, 2) + "\nYou are Overweight");
            }
            else
            {
                Console.WriteLine("BMI: " + Math.Round(bmi, 2) + "\nYou are Obese");
            }

            Console.WriteLine(); 
        }
    }
}
