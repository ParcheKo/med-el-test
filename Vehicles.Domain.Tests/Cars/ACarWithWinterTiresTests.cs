using FluentAssertions;
using Vehicles.Domain.Cars;
using Vehicles.Domain.Cars.Builders;
using Vehicles.Domain.Tire;
using Xunit;

namespace Vehicles.Domain.Tests.Cars;

public class ACarWithWinterTiresTests
{
    private readonly Car _aCarWithWinterTires;

    public ACarWithWinterTiresTests()
    {
        _aCarWithWinterTires = CarFactory.New().FabricatedBy(Brands.Toyota).Build();
        _aCarWithWinterTires.SwitchTiresFor(WinterTires.WithSpec(2.7F, -10, 1));
    }

    [Fact]
    public void tires_can_be_switched_back_to_summer_ones()
    {
        _aCarWithWinterTires.SwitchTiresFor(SummerTires.WithSpec(2.35F, 45));
        _aCarWithWinterTires.Tires.Type.Should().Be(TireTypes.Summer);
        _aCarWithWinterTires.Tires.Pressure.Should().Be(2.35F);
        _aCarWithWinterTires.Tires.As<SummerTires>().MaximumTemperature.Should().Be(45);
    }
}