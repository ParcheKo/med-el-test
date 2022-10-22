using System.Collections.Generic;
using System.Linq;

namespace Vehicles.Domain.Tests.Helpers;

public static class Extensions
{
    public static TTarget As<TSource, TTarget>(this TSource value) where TTarget : TSource
    {
        return new List<TSource>
        {
            value
        }.OfType<TTarget>().Single();
    }
}