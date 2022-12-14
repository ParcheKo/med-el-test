namespace Vehicles.Domain.Cars.Builders;

public interface ICarBuilder
{
    ICarBuilder FabricatedBy(Brands brand);
    Car Build();
}