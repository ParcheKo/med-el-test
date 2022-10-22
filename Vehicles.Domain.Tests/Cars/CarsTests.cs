using System;
using FluentAssertions;
using Vehicles.Domain.Cars.Builders;
using Xunit;

namespace Vehicles.Domain.Tests.Cars;

public class CarsTests
{
    [Theory]
    [InlineData(Brands.Toyota)]
    [InlineData(Brands.Honda)]
    public void can_be_fabricated_by(Brands brand)
    {
        var car = CarFactory.New().FabricatedBy(brand).Build();
        Assert.True(car.Make == brand);
    }

    [Theory]
    [InlineData(Brands.KTM)]
    public void can_not_be_fabricated_by(Brands brand)
    {
        var action = () => _ = CarFactory.New().FabricatedBy(brand).Build();
        action.Should().Throw<NotSupportedException>();
    }
}