namespace Vehicles.Domain.Motorcycles.Builders;

public interface IMotorcycleBuilder
{
    IMotorcycleBuilder FabricatedBy(Brands brand);
    Motorcycle Build();
}