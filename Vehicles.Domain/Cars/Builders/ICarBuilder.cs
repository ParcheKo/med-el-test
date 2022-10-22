namespace Vehicles.Domain.Cars.Builders;

public interface ICarBuilder
{
    ICarBuilder FabricatedBy(string make);
    Car Build();
}