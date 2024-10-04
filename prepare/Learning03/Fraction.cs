

public class Fraction
{

    private int _numerator;
    private int _denominator;

    public void FractionNumber()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public void FractionNumber(int number1)
    {
        _numerator = number1;
        _denominator = 1;
    }

    public void FractionNumber(int number1, int number2)
    {
        _numerator = number1;
        _denominator = number2;
    }

    public void GetFraction()
    {
        // if (_denominator == 1)
        // {
        //     Console.WriteLine($"The fraction is this whole number: {_numerator}.");
        // }
        // else
            Console.WriteLine($"The fraction is: {_numerator}/{_denominator}");
    }

    public void GetDecimalValue()
    {

        Console.WriteLine((double) _numerator / (double) _denominator);

    }




}