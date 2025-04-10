using System;

//Class responsible for creating goal objects from string representations
public static class GoalFactory
{
    //Set method
    //Creates a Goal object from its string representation
    public static Goal CreateGoalFromString(string data)
    {
        string[] parts = data.Split(':');
        string type = parts[0];
        string[] fields = parts[1].Split(',');

        switch (type)
        {
            case "SimpleGoal":
                var simple = new SimpleGoal(fields[0], fields[1], int.Parse(fields[2]));
                typeof(SimpleGoal)
                    .GetField("_isComplete", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                    .SetValue(simple, bool.Parse(fields[3]));
                return simple;

            case "EternalGoal":
                return new EternalGoal(fields[0], fields[1], int.Parse(fields[2]));

            case "ChecklistGoal":
                var checklist = new ChecklistGoal(fields[0], fields[1], int.Parse(fields[2]), int.Parse(fields[4]), int.Parse(fields[3]));
                typeof(ChecklistGoal)
                    .GetField("_amountCompleted", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                    .SetValue(checklist, int.Parse(fields[5]));
                return checklist;

            default:
                throw new Exception("Unknown goal type.");
        }
    }
}