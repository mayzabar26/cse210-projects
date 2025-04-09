

public class Rectangle : Shape 
{
    //Set the Variables
    private double _length;
    private double _width;


    //Set the Constructor
    public Rectangle(double length, double width, string color) : base(color)
    {
        _length = length; 
        _width = width;
    }


    //Set the Method
    public override double GetArea()
    {
        return _length * _width;
    }
}