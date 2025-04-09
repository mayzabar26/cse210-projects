using System;

public abstract class Goal
{
    //Set variables
    private string _shortName;
    private string _description;
    private string _points;


    //Set constructors
    public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }


    //Set getters and setters
    public string GetShortName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetPoints()
    {
        return _points;
    }


    //Set methods
    //This method returns whether the goal is complete
    public abstract bool IsComplete();

    //This method handles what happens when the goal is recorded
    public abstract int RecordEvent();

    //Virtual method to show the details of the goal
    public virtual string GetDetailsString()
    {
        return $"{_shortName} ({_description})";
    }


    //Virtual method to serialize the goal to a string
    public virtual string GetStringRepresentation()
    {
        return $"{GetType().Name}:{_shortName},{_description},{_points}";
    }
}