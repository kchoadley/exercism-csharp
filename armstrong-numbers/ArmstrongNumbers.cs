using System;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number) =>
        CalculateArmstrong(number.ToString(), number.ToString().Length) == number;

    public static int CalculateArmstrong(string intAsString, int power) =>
        intAsString.Length == 1 ?
        int.Parse(intAsString).Pow(power) :
        CalculateArmstrong(intAsString.Substring(1), power) + int.Parse(intAsString.Substring(0, 1)).Pow(power);

    public static int Pow(this int number, int power) =>
        power == 0 ?
        1 :
        (
            power == 1 ?
            number :
            number * number.Pow(power - 1)
        );

}