namespace Vehicles.Domain.Tire;

public class SummerTires : Tires
{
    private SummerTires(
        float pressure,
        float maximumTemperature
    )
    {
        Pressure = pressure;
        MaximumTemperature = maximumTemperature;
    }

    public override TireTypes Type => TireTypes.Summer;
    public override float Pressure { get; }

    public override string Specification =>
        string.Join(
            ", ", new List<string>
            {
                $"Pressure: {Pressure}bar",
                $"MaximumTemperature: {MaximumTemperature}°C"
            }
        );

    public float MaximumTemperature { get; }

    public static SummerTires WithSpec(
        float pressure,
        float maximumTemperature
    )
    {
        return new SummerTires(pressure, maximumTemperature);
    }
}