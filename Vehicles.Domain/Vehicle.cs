namespace Vehicles.Domain;

public abstract class Vehicle
{
    public abstract Brand Make { get; }
    public abstract void Move();
}