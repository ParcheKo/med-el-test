namespace Vehicles.Domain.Cars.Builders;

internal class CarBuilder : ICarBuilder
{
    private string _make = string.Empty;

    public ICarBuilder FabricatedBy(string make)
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