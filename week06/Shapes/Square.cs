

public class Square : Shape 
{
    //Set the Variables
    private double _side;


    //Set the Constructor
    public Square(double side, string color) : base(color) 
    {
        _side = side;
    }


    //Set the Getter
    public override double GetArea()
    {
        return _side * _side;
    }
}