using Vehicles.Domain.Cars;

namespace Vehicles.Domain.Motorcycles.Builders;

internal class MotorcycleBuilder : IMotorcycleBuilder
{
    private string _make = string.Empty;

    public IMotorcycleBuilder MadeBy(string make)
    {
        _make = make;
        return this;
    }

    public Motorcycle Build()
    {
        var car = new Motorcycle(_make);
        return car;
    }
}