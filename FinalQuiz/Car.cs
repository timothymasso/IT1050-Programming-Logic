using System;

public class Car : Vehicle
{
    public bool IsElectric { get; set; }

    public Car(string make, string model, int year, bool isElectric)
        : base(make, model, year)
    {
        IsElectric = isElectric;
    }

    public override void DisplayInfo()
    {
        var electricText = IsElectric ? "Electric" : "Gas";
        Console.WriteLine($"{Year} {Make} {Model} - {electricText}");
    }

    public void Register(string ownerName)
    {
        Console.WriteLine($"{Make} {Model} ({Year}) has been registered to {ownerName}.");
    }
}

