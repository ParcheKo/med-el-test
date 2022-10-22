namespace Vehicles.Domain.Motorcycles.Builders;

public static class MotorcycleFactory
{
    public static IMotorcycleBuilder New()
    {
        return new MotorcycleBuilder();
    }
}