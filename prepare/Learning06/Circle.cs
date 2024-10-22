public class Circle : Shape
{
    private double _radius;
    private double pi = Math.PI;

    
    public Circle(string colour, string name, double radius) : base (colour, name)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return pi * (_radius *_radius);
    }

    // public void SetRadius(double radius)
    // {
    //     _radius = radius;
    // }
}