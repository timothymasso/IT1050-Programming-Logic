using System;

class Program
{
    static void Main()
    {
        string itemname;
        int quantity=0;
        double unitprice = 0;
        double discountpercent = 0;
        double finalprice = 0;

        Console.Write("Enter name of item: ");
        itemname = Console.ReadLine();

        Console.Write("Enter quantity of item: ");
        quantity = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter unit price of item without $: ");
        unitprice = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter discount percentage as a decimal: ");
        discountpercent = Convert.ToDouble(Console.ReadLine());

        finalprice = quantity * unitprice;

        finalprice = finalprice - (finalprice * discountpercent);
        
        Console.WriteLine("\nName of item: " + itemname);
        Console.WriteLine("Quantity of item: " + quantity);
        Console.WriteLine("Dicount on item: " + discountpercent.ToString("P0"));
        Console.WriteLine("Unit price of item: ${0}", unitprice);
        Console.WriteLine("Total price of item (with tax): $" + Math.Round(finalprice, 2));
    }
}
