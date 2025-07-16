using System;

class Program
{
    static void Main(string[] args)
    {
        // This code requires you to hard code in values for a fraction and the decimal for that fraction.
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.BuildFraction());
        Console.WriteLine(f1.DecimalValue());

        Fraction f2 = new Fraction(20);
        Console.WriteLine(f2.BuildFraction());
        Console.WriteLine(f2.DecimalValue());
        Console.WriteLine("\nThe Numerator is 20 because it is hard Coded in. The Default is also hard coded to 1/1");




    }
}