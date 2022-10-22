using FluentAssertions;
using Vehicles.Domain.Cars;
using Vehicles.Domain.Cars.Builders;
using Vehicles.Domain.Tire;
using Xunit;

namespace Vehicles.Domain.Tests;

public class ACarWithWinterTiresTests
{
    private readonly Car _newBmwCar;
    public ACarWithWinterTiresTests()
    {
        _newBmwCar = CarFactory.New().FabricatedBy(Brands.Toyota).Build();
        _newBmwCar.SwitchTiresTo(WinterTires.WithSpec(2.7F, -10, 1));
    }

    [Fact]
    public void tires_can_be_switched_back_to_summer_ones()
    {
        _newBmwCar.SwitchTiresTo(SummerTires.WithSpec(2.35F, 45));
        _newBmwCar.Tires.Type.Should().Be(TireTypes.Summer);
        _newBmwCar.Tires.Pressure.Should().Be(2.35F);
        _newBmwCar.Tires.As<SummerTires>().MaximumTemperature.Should().Be(45);
    }
}