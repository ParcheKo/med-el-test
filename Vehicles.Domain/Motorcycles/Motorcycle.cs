using System.Diagnostics;
using Vehicles.Domain.Cars;

namespace Vehicles.Domain.Motorcycles;

public class Motorcycle : Vehicle
{
    public Motorcycle(Brands make)
    {
        Make = make;
    }

    public override Brands Make { get; }

    public override void Move()
    {
        Debug.WriteLine($"You are driving a motorcycle from {Make}");
    }
}