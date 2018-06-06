using System;
using System.Linq;

public static class ReverseString
{
    /// <summary>
    /// A functional recursive solution to reversing a string.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string Reverse(string input)
    {
        if(input == string.Empty)
        {
            return string.Empty;
        }
        else
        {
            return input.Last() + Reverse(input.Substring(0, input.Length - 1));
        }
    }
    //public static string Reverse(string input)
    //{
    //    var response = string.Empty;
    //    if (input != string.Empty)
    //    {
    //        var charArray = input.ToCharArray();
    //        Array.Reverse(charArray);
    //        response = new string(charArray);
    //    }
    //    return response;
    //}
}