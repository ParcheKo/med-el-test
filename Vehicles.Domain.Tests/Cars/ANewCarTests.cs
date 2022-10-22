using FluentAssertions;
using Vehicles.Domain.Cars;
using Vehicles.Domain.Cars.Builders;
using Vehicles.Domain.Tire;
using Xunit;

namespace Vehicles.Domain.Tests.Cars;

public class ANewCarTests
{
    private readonly Car _aNewCar;

    public ANewCarTests()
    {
        _aNewCar = CarFactory.New().FabricatedBy(Brands.Toyota).Build();
    }

    [Fact]
    public void should_have_summer_tires_preinstalled()
    {
        _aNewCar.Tires.Type.Should().Be(TireTypes.Summer);
        _aNewCar.Tires.Pressure.Should().Be(2.5F);
        _aNewCar.Tires.As<SummerTires>().MaximumTemperature.Should().Be(50);
    }


    [Fact]
    public void default_tires_can_be_switched_for_another_summer_type()
    {
        _aNewCar.SwitchTiresFor(SummerTires.WithSpec(2.3F, 42));
        _aNewCar.Tires.Type.Should().Be(TireTypes.Summer);
        _aNewCar.Tires.Pressure.Should().Be(2.3F);
        _aNewCar.Tires.As<SummerTires>().MaximumTemperature.Should().Be(42);
    }

    [Fact]
    public void default_tires_can_be_switched_for_a_winter_type()
    {
        _aNewCar.SwitchTiresFor(WinterTires.WithSpec(2.7F, -10, 1));
        _aNewCar.Tires.Type.Should().Be(TireTypes.Winter);
        _aNewCar.Tires.Pressure.Should().Be(2.7F);
        _aNewCar.Tires.As<WinterTires>().MinimumTemperature.Should().Be(-10);
        _aNewCar.Tires.As<WinterTires>().Thickness.Should().Be(1);
    }
}