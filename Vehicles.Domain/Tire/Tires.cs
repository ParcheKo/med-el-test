namespace Vehicles.Domain.Tire;

public abstract class Tires
{
    public abstract TireTypes Type { get; }
    public abstract float Pressure { get; }
    public abstract string Specification { get; }
}