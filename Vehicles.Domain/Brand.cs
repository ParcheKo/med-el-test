using Vehicles.Framework;

namespace Vehicles.Domain;

public abstract class Brand : ValueObject
{
    protected Brand(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public static implicit operator Brands(Brand brand)
    {
        return Enum.Parse<Brands>(brand.Name);
    }
}