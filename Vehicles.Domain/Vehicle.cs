namespace Vehicles.Domain;

public abstract class Vehicle
{
    public Brand Make { get; }
    public abstract void Move();

    protected Vehicle(Brand make)
    {
        Make = make;
    }
}