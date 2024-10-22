using System.Reflection.Metadata.Ecma335;

public class Square : Shape
{
    private double _side = 0;


    public Square(string colour, string name, double side) : base (colour, name)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
    // public void SetSide(double side)
    // {
    //     _side = side;
    // }
}