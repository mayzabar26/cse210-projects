public class Running : Activity
{
    //Set variables
    private double _distance;


    //Set constructors
    public Running(string date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }


    //Set methods
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetDuration()) * 60; 
    }

    public override double GetPace()
    {
        return GetDuration() / _distance;
    }
}