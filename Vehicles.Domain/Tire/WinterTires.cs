namespace Vehicles.Domain.Tire;

public class WinterTires : Tires
{
    private WinterTires(
        float pressure,
        float minimumTemperature,
        float thickness
    )
    {
        Pressure = pressure;
        MinimumTemperature = minimumTemperature;
        Thickness = thickness;
    }

    public override TireTypes Type => TireTypes.Winter;
    public override float Pressure { get; }
    public float MinimumTemperature { get; }
    public float Thickness { get; }

    public override string Specification =>
        string.Join(
            ", ", new List<string>
            {
                $"Pressure: {Pressure}bar",
                $"MinimumTemperature: {MinimumTemperature}°C ",
                $"Thickness: {Thickness}"
            }
        );

    public static WinterTires WithSpec(
        float pressure,
        float minimumTemperature,
        float thickness
    )
    {
        return new WinterTires(pressure, minimumTemperature, thickness);
    }
}