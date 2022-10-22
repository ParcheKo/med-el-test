using System;
using FluentAssertions;
using Vehicles.Domain.Motorcycles.Builders;
using Xunit;

namespace Vehicles.Domain.Tests.Motorcycles;

public class MotorcyclesTests
{
    [Theory]
    [InlineData(Brands.KTM)]
    [InlineData(Brands.Honda)]
    public void can_be_fabricated_by(Brands brand)
    {
        var car = MotorcycleFactory.New().FabricatedBy(brand).Build();
        Assert.True(car.Make == brand);
    }

    [Theory]
    [InlineData(Brands.Toyota)]
    public void can_not_be_fabricated_by(Brands brand)
    {
        var action = () => _ = MotorcycleFactory.New().FabricatedBy(brand).Build();
        action.Should().Throw<NotSupportedException>();
    }
}