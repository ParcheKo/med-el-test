using System.Diagnostics;
using Vehicles.Domain.Tire;

namespace Vehicles.Domain.Cars;

public class Car : Vehicle
{
    private const float DefaultPressure = 2.5F;
    private const int DefaultMaximumTemperature = 50;

    public Car(Brand make): base(make)
    {
    }

    public Tires Tires { get; private set; } = SummerTires.WithSpec(DefaultPressure, DefaultMaximumTemperature);


    public void SwitchTiresFor(Tires tires)
    {
        Tires = tires;
    }

    public override void Move()
    {
        Debug.Print($"You are driving a car from {Make.Name} using tires with the following spec: {Tires.Specification}");
    }
}