namespace Vehicles.Domain.Cars.Builders;

internal class CarBuilder : ICarBuilder
{
    private Brands _make;

    public ICarBuilder FabricatedBy(Brands make)
    {
        _make = make;
        return this;
    }

    public Car Build()
    {
        var car = new Car(_make);
        return car;
    }
}