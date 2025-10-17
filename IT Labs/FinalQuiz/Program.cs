using System;

internal class Program
{
    private static void Main(string[] args)
    {
        var registry = new VehicleRegistry();

        var car1 = new Car("Tesla", "Model 3", 2022, true);
        var car2 = new Car("Toyota", "Camry", 2018, false);

        registry.AddCar(car1);
        registry.AddCar(car2);

        registry.ListCars();

        registry.RegisterAll("Alice");

        registry.ListCars();
    }
}
