using Vehicles.Domain.Cars;

namespace Vehicles.Domain;

public abstract class Vehicle
{
    public abstract Brands Make { get; }
    public abstract void Move();
}