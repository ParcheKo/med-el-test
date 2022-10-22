using FluentAssertions;
using Vehicles.Domain.Cars.Builders;
using Xunit;

namespace Vehicles.Domain.Tests;

public class CarsTests
{
    [Theory]
    [InlineData("Toyota")]
    [InlineData("Honda")]
    public void can_be_made_by(string make)
    {
        var car = CarFactory.New().FabricatedBy(make).Build();
        car.Make.Should().Be(make);
    }
}