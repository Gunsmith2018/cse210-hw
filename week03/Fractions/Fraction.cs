public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        // Setting the Numerator and Denominator to 1/1
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int wholenumber)
    {
        _numerator = wholenumber;
        _denominator = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public string BuildFraction()
    {
        string text = $"{_numerator}/{_denominator}";
        return text;
    }


    public double DecimalValue()
    {
        return (double)_numerator / (double)_denominator;
    }
}