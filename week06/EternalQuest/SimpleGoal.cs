using System;

public class SimpleGoal : Goal
{
    //Set variables
    private bool _isComplete;


    //Set constructors
    public SimpleGoal(string shortName, string description, string points) : base(shortName, description, points)
    {
        _isComplete = false;
    }


    //Set getters and setters
    //Returns a string showing goal status and description
    public override string GetDetailsString()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {GetShortName()} ({GetDescription()})";
    }

    //Returns a string to save the goal state
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetShortName()},{GetDescription()},{GetPoints()},{_isComplete}";
    }


    //Set Methods
    //Returns whether the goal is complete
    public override bool IsComplete()
    {
        return _isComplete;
    }

    //Marks the goal as complete and returns the points
    public override int RecordEvent()
    {
        _isComplete = true;
        return GetPoints();
    }
}