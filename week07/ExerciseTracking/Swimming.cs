public class Swimming : Activity
{
    //Set variables
    private int _laps;


    //Set constructors
    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }


    //Set methods
    public override double GetDistance()
    {
        return _laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetDuration()) * 60; 
    }

    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }
}