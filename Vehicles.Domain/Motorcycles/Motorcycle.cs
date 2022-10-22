using System.Diagnostics;

namespace Vehicles.Domain.Motorcycles;

public class Motorcycle : Vehicle
{
    public Motorcycle(Brand make)
    {
        Make = make;
    }

    public override Brand Make { get; }

    public override void Move()
    {
        Debug.WriteLine($"You are driving a motorcycle from {Make.Name}");
    }
}