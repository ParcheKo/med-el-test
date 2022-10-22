namespace Vehicles.Domain.Cars;

public class CarBrand : Brand
{
    private readonly IList<Brands> _supportedBrands = new List<Brands>
    {
        Brands.Honda, Brands.Toyota
    };

    private CarBrand(Brands brand) : base($"{brand}")
    {
        if (!_supportedBrands.Contains(brand)) throw new NotSupportedException($"Can not build a car from brand {brand}");
    }


    public static CarBrand Of(Brands brand)
    {
        return new CarBrand(brand);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Name;
    }
}