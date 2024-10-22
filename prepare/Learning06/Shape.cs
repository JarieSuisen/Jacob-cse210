 public abstract class Shape
 {

    string _colour;
    string _name;

    public Shape(string colour, string name)
    {
        _colour = colour;
        _name = name;
    }
    public void SetColour(string colour)
    {
        _colour = colour;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetColour()
    {
        return _colour;
    }

    public abstract double GetArea();

 }