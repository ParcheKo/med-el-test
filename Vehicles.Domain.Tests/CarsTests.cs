using FluentAssertions;
using Vehicles.Domain.Cars;
using Vehicles.Domain.Cars.Builders;
using Xunit;

namespace Vehicles.Domain.Tests;

public class CarsTests
{
    [Theory]
    [InlineData(Brands.Toyota)]
    [InlineData(Brands.Honda)]
    public void can_be_made_by(Brands make)
    {
        var car = CarFactory.New().FabricatedBy(make).Build();
        car.Make.Should().Be(make);
    }
}