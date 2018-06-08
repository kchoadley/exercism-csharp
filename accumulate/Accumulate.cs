using System;
using System.Collections.Generic;
using System.Linq;

public static class AccumulateExtensions
{
    public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
    {
        List<U> temp = new List<U>();
        foreach (var item in collection)
        {
            temp.Add(func(item));
        }
        return temp;
    }
}