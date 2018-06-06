using System;
using System.Collections.Generic;
using System.Text;

public static class Raindrops
{
    private static Dictionary<int, string> map = new Dictionary<int, string>
    {
        {3, "Pling"},
        {5, "Plang"},
        {7, "Plong"}
    };

    public static string Convert(int number)
    {
        var result = new StringBuilder();

        foreach(int key in map.Keys)
        {
            if (number % key == 0)
            {
                result.Append(map[key]);
            }
        }
        if(result.Length == 0)
        {
            result.Append(number.ToString());
        }

        return result.ToString();
    }
}