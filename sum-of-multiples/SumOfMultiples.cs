using System;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        return SumHelper(multiples, max - 1);
    }

    private static int SumHelper(IEnumerable<int> multiples, int current)
    {
        if(current < 1)
        {
            return 0;
        }
        else
        {
            return current.IsMultipleOf(multiples) ? current + SumHelper(multiples, current - 1) : SumHelper(multiples, current - 1);
        }
    }

    private static Boolean IsMultipleOf(this int numerator, IEnumerable<int> denominators)
    {
        foreach (int denominator in denominators)
        {
            if (numerator % denominator == 0)
            {
                return true;
            }
        }
        return false;
    }
}