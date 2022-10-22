using System.Diagnostics;
using Vehicles.Domain.Tire;

namespace Vehicles.Domain.Cars;

public class Car : Vehicle
{
    private const float DefaultPressure = 2.5F;
    private const int DefaultMaximumTemperature = 50;

    public Car(string make)
    {
        Make = make;
    }

    public Tires Tires { get; private set; } = SummerTires.WithSpec(DefaultPressure, DefaultMaximumTemperature);

    public override string Make { get; }

    public void SwitchTiresTo(Tires tires)
    {
        Tires = tires;
    }

    public override void Move()
    {
        Debug.Print($"You are driving a car from {Make} using tires with the following spec: {Tires.Specification}");
    }
}