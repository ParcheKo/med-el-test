using Vehicles.Domain.Cars;

namespace Vehicles.Domain.Motorcycles.Builders;

public interface IMotorcycleBuilder
{
    IMotorcycleBuilder MadeBy(string make);
    Motorcycle Build();
}