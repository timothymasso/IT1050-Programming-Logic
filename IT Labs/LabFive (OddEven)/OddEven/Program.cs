using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] OddNum = new int[10];
        int[] EvenNum = new int[10];
        int oddIndex = 0;
        int evenIndex = 0;
        int num = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                EvenNum[evenIndex++] = num;
            }
            else
            {
                OddNum[oddIndex++] = num;
            }
        }

        Array.Sort(OddNum, 0, oddIndex); 
        Array.Sort(EvenNum, 0, evenIndex);
        Array.Reverse(EvenNum, 0, evenIndex); 

        Console.WriteLine("Odd Numbers in descending order:");
        for (int i = oddIndex - 1; i >= 0; i--)
        {
            Console.Write(OddNum[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Even Numbers in ascending order:");
        for (int i = evenIndex - 1; i >= 0; i--)
        {
            Console.Write(EvenNum[i] + " ");
        }
        Console.WriteLine();

        int sumOdd = OddNum.Take(oddIndex).Sum();
        int sumEven = EvenNum.Take(evenIndex).Sum();

        Console.WriteLine("Sum of Odd Numbers = " + sumOdd);
        Console.WriteLine("Sum of Even Numbers = " + sumEven);
    }
}