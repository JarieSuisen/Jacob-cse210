using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning03 World!");

        Fraction Fraction = new Fraction();

        // Set the fraction. Can either leave variable blank, set a single number for whole number or two numbers for full fraction.
        Console.WriteLine("Default fraction");
        Fraction.FractionNumber();

        // Print the fraction
        Fraction.GetFraction();
        // Print the Decimal form
        Fraction.GetDecimalValue();
        
        // Set the fraction. Can either leave variable blank, set a single number for whole number or two numbers for full fraction.
        Console.WriteLine("Numerator Only, Whole Number");
        Fraction.FractionNumber(5);

        // Print the fraction
        Fraction.GetFraction();
        Fraction.GetDecimalValue();

        // Set the fraction. Can either leave variable blank, set a single number for whole number or two numbers for full fraction.
        Console.WriteLine("Full Fraction Entered");
        Fraction.FractionNumber(4,3);

        // Print the fraction
        Fraction.GetFraction();
        Fraction.GetDecimalValue();


        Console.WriteLine();

    }
}