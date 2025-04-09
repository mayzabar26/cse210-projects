

public class Circle : Shape
{
    //Set the Variables
    private double _radius;


    //Set the Constructor
    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
    }


    //Set the Method
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}