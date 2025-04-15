using System;

public abstract class Activity
{
    //Set variables
    private string _date;
    private int _duration;


    //Set constructors
    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }


    //Set methods
    public string GetDate()
    {
        return _date;
    }

    public int GetDuration()
    {
        return _duration;
    }

    //Abstract Methods: Will be implemented in derivated classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

   public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_duration} min): " +
            $"Distance: {GetDistance():0.0}, " +
            $"Speed: {GetSpeed():0.0}, " +
            $"Pace: {GetPace():0.00} min per unit";
    }

}