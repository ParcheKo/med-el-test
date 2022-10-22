using Vehicles.Domain.Cars;

namespace Vehicles.Domain.Motorcycles;

public class MotorcycleBrand : Brand
{
    private readonly IList<Brands> _supportedBrands = new List<Brands>
    {
        Brands.Honda, Brands.KTM
    };

    private MotorcycleBrand(Brands brand) : base($"{brand}")
    {
        if (!_supportedBrands.Contains(brand)) throw new NotSupportedException($"Can not build a motorcycle from brand {brand}");
    }


    public static MotorcycleBrand Of(Brands brand)
    {
        return new MotorcycleBrand(brand);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Name;
    }
}