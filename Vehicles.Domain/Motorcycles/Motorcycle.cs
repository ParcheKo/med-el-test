using System.Diagnostics;

namespace Vehicles.Domain.Motorcycles;

public class Motorcycle : Vehicle
{
    public Motorcycle(string make)
    {
        Make = make;
    }

    public override string Make { get; }

    public override void Move()
    {
        Debug.WriteLine($"You are driving a motorcycle from {Make}");
    }
}