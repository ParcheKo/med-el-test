using System.Diagnostics;

namespace Vehicles.Domain.Motorcycles;

public class Motorcycle : Vehicle
{
    public Motorcycle(Brand make): base(make)
    {
        
    }

    public override void Move()
    {
        Debug.WriteLine($"You are driving a motorcycle from {Make.Name}");
    }
}