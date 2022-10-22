namespace Vehicles.Domain.Cars.Builders;

public static class CarFactory
{
    public static ICarBuilder New()
    {
        return new CarBuilder();
    }
}