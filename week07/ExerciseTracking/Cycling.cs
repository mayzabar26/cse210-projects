public class Cycling : Activity
{
    //Set variables
    private double _speed;


    //Set constructors
    public Cycling(string date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }


    //Set methods
    public override double GetDistance()
    {
        return (_speed / 60) * GetDuration();
    }

    public override double GetSpeed()
    {
        return _speed; 
    }

    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }
}