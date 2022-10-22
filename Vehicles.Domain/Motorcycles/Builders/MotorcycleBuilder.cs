namespace Vehicles.Domain.Motorcycles.Builders;

internal class MotorcycleBuilder : IMotorcycleBuilder
{
    private Brands _brand;

    public IMotorcycleBuilder FabricatedBy(Brands brand)
    {
        _brand = brand;
        return this;
    }

    public Motorcycle Build()
    {
        return new Motorcycle(MotorcycleBrand.Of(_brand));
    }
}