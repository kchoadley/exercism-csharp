using System;
using System.Diagnostics;

public static class RealNumberExtension
{
    public static double Expreal(this int realNumber, RationalNumber r) =>
        Math.Pow(realNumber, (double)r.Numerator / (double)r.Denominator);
    public static int Pow(this int number, int power) =>
        power < 0 ? Pow(1 / number, power * -1) :
        power == 0 ? 1 :
        power == 1 ? number :
            number * Pow(number, power - 1);
}

public struct RationalNumber
{
    public int Numerator { get; }
    public int Denominator { get; }
    public RationalNumber(int numerator, int denominator)
    {
        if (denominator == 0)   // cannot divide by zero
        {
            throw new NotFiniteNumberException();
        }
        int gcd = Gcd(numerator, denominator);
        if(denominator < 0) // ensures only the numerator is ever negative
        {
            Numerator = -1 * numerator / gcd;
            Denominator = -1 * denominator / gcd;
        }
        else
        {
            Numerator = numerator / gcd;
            Denominator = denominator / gcd;
        }
    }

    public RationalNumber Add(RationalNumber r) =>
            new RationalNumber(this.Numerator* r.Denominator + this.Denominator* r.Numerator, this.Denominator* r.Denominator);

    public static RationalNumber operator +(RationalNumber r1, RationalNumber r2) =>
            new RationalNumber(r1.Numerator * r2.Denominator + r1.Denominator * r2.Numerator, r1.Denominator * r2.Denominator);

    public RationalNumber Sub(RationalNumber r) =>
            new RationalNumber(this.Numerator* r.Denominator - this.Denominator* r.Numerator, this.Denominator* r.Denominator);

    public static RationalNumber operator -(RationalNumber r1, RationalNumber r2) =>
            new RationalNumber(r1.Numerator * r2.Denominator - r1.Denominator * r2.Numerator, r1.Denominator * r2.Denominator);

    public RationalNumber Mul(RationalNumber r) =>
            new RationalNumber(this.Numerator * r.Numerator, this.Denominator * r.Denominator);

    public static RationalNumber operator *(RationalNumber r1, RationalNumber r2) =>
            new RationalNumber(r1.Numerator * r2.Numerator, r1.Denominator * r2.Denominator);

    public RationalNumber Div(RationalNumber r) =>
            new RationalNumber(this.Numerator * r.Denominator, this.Denominator * r.Numerator);

    public static RationalNumber operator /(RationalNumber r1, RationalNumber r2) =>
            new RationalNumber(r1.Numerator * r2.Denominator, r1.Denominator * r2.Numerator);

    public RationalNumber Abs() =>
        new RationalNumber(Numerator > 0 ? Numerator : Numerator * -1, Denominator);

    public RationalNumber Reduce() =>
        new RationalNumber(Numerator, Denominator);

    public RationalNumber Exprational(int power) =>
        new RationalNumber(Numerator.Pow(power), Denominator.Pow(power));

    public double Expreal(int baseNumber) =>
        Math.Pow(baseNumber, (double)this.Numerator / (double)this.Denominator);

    private static int Gcd(int a, int b) =>
        Math.Abs(b) == 0 ? Math.Abs(a)
        : Gcd(Math.Abs(b), Math.Abs(a) % Math.Abs(b));

}