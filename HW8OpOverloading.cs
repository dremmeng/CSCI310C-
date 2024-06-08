// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
public class Fraction
{
    private int numerator;
    private int denominator;

    public Fraction(int numerator, int denominator)
    {
        this.Numerator = numerator;
        this.Denominator = denominator;
    }

    private int Numerator
    {
        get { return this.numerator; }
        set { this.numerator = value; }
    }

    private int Denominator
    {
        get { return this.denominator; }
        set { this.denominator = value; }
    }

    public static Fraction operator *(Fraction a, Fraction b)
        => new Fraction(a.numerator * b.numerator, a.denominator * b.denominator);
    public static Fraction operator /(Fraction a, Fraction b)
    {
        if (b.numerator == 0)
        {
            throw new DivideByZeroException();
        }
        return new Fraction(a.numerator * b.denominator, a.denominator * b.numerator);
    }
    public void PrintFraction()
    {
        Console.WriteLine($"{this.Numerator}/{this.Denominator}");
    }

    public override string ToString()
    {
        return $"{this.Numerator}/{this.Denominator}";
    }
}
public class CSFractions
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction(3, 5);
        frac1.PrintFraction();
        Console.WriteLine($"This fraction is: {frac1.ToString()}");
        Fraction frac2 = new Fraction(1, 5);
        frac2.PrintFraction();
        Console.WriteLine($"This other fraction is: {frac2}");
        Console.WriteLine(frac1 * frac2);
        Console.WriteLine(frac1 / frac2);
    }
}