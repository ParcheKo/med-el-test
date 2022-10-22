using Vehicles.Domain.Cars;

namespace Vehicles.Domain.Motorcycles.Builders;

internal class MotorcycleBuilder : IMotorcycleBuilder
{
    private Brands _make;

    public IMotorcycleBuilder FabricatedBy(Brands make)
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