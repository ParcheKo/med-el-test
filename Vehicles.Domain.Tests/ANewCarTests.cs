using FluentAssertions;
using Vehicles.Domain.Cars;
using Vehicles.Domain.Cars.Builders;
using Vehicles.Domain.Tire;
using Xunit;

namespace Vehicles.Domain.Tests;

public class ANewCarTests
{
    private readonly Car _newBmwCar;
    public ANewCarTests()
    {
        _newBmwCar = CarFactory.New().FabricatedBy("Toyota").Build();
    }
    
    [Fact]
    public void should_have_summer_tires_preinstalled()
    {
        _newBmwCar.Tires.Type.Should().Be(TireTypes.Summer);
        _newBmwCar.Tires.Pressure.Should().Be(2.5F);
        _newBmwCar.Tires.As<SummerTires>().MaximumTemperature.Should().Be(50);
    }
    
    [Fact]
    public void tires_can_be_switched_to_winter_ones()
    {
        _newBmwCar.SwitchTiresTo(WinterTires.WithSpec(2.7F, -10, 1));
        _newBmwCar.Tires.Type.Should().Be(TireTypes.Winter);
        _newBmwCar.Tires.Pressure.Should().Be(2.7F);
        _newBmwCar.Tires.As<WinterTires>().MinimumTemperature.Should().Be(-10);
        _newBmwCar.Tires.As<WinterTires>().Thickness.Should().Be(1);
    }
}