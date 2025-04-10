
public class EternalGoal : Goal
{
    //Set constructors
    public EternalGoal(string shortName, string description, int points) : base (shortName, description, points)
    {}


    //Set getters and setters
    //Returns a string to save the goal
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetShortName()},{GetDescription()},{GetPoints()}";
    }

    //Returns details without a completion mark
    public override string GetDetailsString()
    {
        return $"[∞] {GetShortName()} ({GetDescription()})";
    }


    //Set methods
    //Always return points when event is recorded
    public override int RecordEvent()
    {
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return false;
    }
}