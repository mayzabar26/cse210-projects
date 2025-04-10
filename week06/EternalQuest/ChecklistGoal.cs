
public class ChecklistGoal : Goal
{
    //Set variables
    private int _amountCompleted;
    private int _target;
    private int _bonus;


    //Set constructors
    public ChecklistGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }


    //Set getters and setters
    //Shows status and progress
    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {GetShortName()} ({GetDescription()}) -- Completed {_amountCompleted}/{_target}";
    }

    //Returns a string for saving the goal
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetShortName()},{GetDescription()},{GetPoints()},{_bonus},{_target},{_amountCompleted}";
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public int GetTarget()
    {
        return _target;
    }

    public int GetBonus() //Creativity: this part is related to the 3 option of the meny
    {
        return _bonus;
    }

    //Set methods
    //Returns true if goal is fully completed
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    //Records progress and returns points (with bonus if completed)
    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            _amountCompleted++;
            return _amountCompleted == _target ? GetPoints() + _bonus : GetPoints();
        }
        return 0;
    } 


}