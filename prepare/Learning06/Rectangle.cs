public class Rectangle : Shape
{
    private double _length = 0;
    private double _width = 0;

    
    public Rectangle(string colour, string name, double length, double width) : base (colour, name)
    {
        _length = length;
        _width = width;
    }
    
    public override double GetArea()
    {
        return _length * _width;
    }

    // public void SetSides(double length, double width)
    // {
    //     _length = length;
    //     _width = width;
    // }
}