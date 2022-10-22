namespace Vehicles.Domain;

public abstract class Vehicle
{
    public abstract string Make { get; }
    public abstract void Move();
}