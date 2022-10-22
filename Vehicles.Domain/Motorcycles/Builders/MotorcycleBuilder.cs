using Vehicles.Domain.Cars;

namespace Vehicles.Domain.Motorcycles.Builders;

internal class MotorcycleBuilder : IMotorcycleBuilder
{
    private Brands _brand;

    public IMotorcycleBuilder FabricatedBy(Brands make)
    {
        _brand = make;
        return this;
    }

    public Motorcycle Build()
    {
        return new Motorcycle(MotorcycleBrand.Of(_brand));
    }
}