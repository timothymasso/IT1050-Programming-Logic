using System;
using System.Collections.Generic;

public class VehicleRegistry
{
    private readonly List<Car> _cars = new List<Car>();

    public void AddCar(Car car)
    {
        _cars.Add(car);
    }

    public void ListCars()
    {
        foreach (var car in _cars)
        {
            car.DisplayInfo();
        }
    }

    public void RegisterAll(string ownerName)
    {
        foreach (var car in _cars)
        {
            car.Register(ownerName);
        }
    }
}
