namespace Vehicles.Domain.Cars.Builders;

internal class CarBuilder : ICarBuilder
{
    private Brands _brand;

    public ICarBuilder FabricatedBy(Brands make)
    {
        _brand = make;
        return this;
    }

    public Car Build()
    {
        return new Car(CarBrand.Of(_brand));
    }
}