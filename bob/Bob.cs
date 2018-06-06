using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        var response = string.Empty;
        if(statement.IsEmpty())
        {
            response = "Fine. Be that way!";
        }
        else if(statement.IsQuestion())
        {
            if(statement.IsShouting())
            {
                response = "Calm down, I know what I'm doing!";
            }
            else
            {
                response = "Sure.";
            }
        }
        else if(statement.IsShouting())
        {
            response = "Whoa, chill out!";
        }
        else
        {
            response = "Whatever.";
        }
        return response;
    }

    /// <summary>
    /// String extension method to determine if the statement to Bob is considered shouting.
    /// A shouting statement contains alpha character and all the alpha characters are upper case.
    /// </summary>
    /// <param name="statement"></param>
    /// <returns></returns>
    private static Boolean IsShouting(this string statement) =>
        statement.Equals(statement.ToUpper()) && statement.Any(char.IsLetter);

    /// <summary>
    /// String extension method to determine if the statement to Bob is considered a question.
    /// A question is a statement that ends with the char '?', not counting any trailing whitespace.
    /// </summary>
    /// <param name="statement"></param>
    /// <returns></returns>
    private static Boolean IsQuestion(this string statement) =>
        statement.TrimEnd().Substring(statement.TrimEnd().Length-1,1).Equals("?");

    /// <summary>
    /// String extension method to determine if the statement to Bob is empty.
    /// An empty statement only contains whitespace or is empty or is null.
    /// </summary>
    /// <param name="statement"></param>
    /// <returns></returns>
    private static Boolean IsEmpty(this string statement) =>
        string.IsNullOrWhiteSpace(statement);
}