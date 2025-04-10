using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    //Set variables
    private List<Goal> _goals;
    private int _score;

    //Set constructor
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    //Set getters and setters
    public int GetScore() => _score;


    //Set methods
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score} points.");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            string checkmark = goal.IsComplete() ? "X" : " ";

            if (goal is ChecklistGoal checklist)
            {
                Console.WriteLine($"{i + 1}. [{checkmark}] {goal.GetShortName()} ({goal.GetDescription()}) -- Currently completed: {checklist.GetAmountCompleted()}/{checklist.GetTarget()}");
            }
            else
            {
                Console.WriteLine($"{i + 1}. [{checkmark}] {goal.GetShortName()} ({goal.GetDescription()})");
            }
        }
    }

    //Creativity: this option will show only the goals details
    public void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            string type = goal.GetType().Name;
            string name = goal.GetShortName();
            string description = goal.GetDescription();
            int points = goal.GetPoints();

            if (goal is ChecklistGoal checklist)
            {
                Console.WriteLine($"{i + 1}. {type} - {name}: {description}, Points: {points}, Target: {checklist.GetTarget()}, Completed: {checklist.GetAmountCompleted()}, Bonus: {checklist.GetBonus()}");
            }
            else
            {
                Console.WriteLine($"{i + 1}. {type} - {name}: {description}, Points: {points}");
            }
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Select a goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string goalName = Console.ReadLine();

        Console.Write("Enter description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points for completion: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        switch (choice)
        {
            case "1":
                newGoal = new SimpleGoal(goalName, description, points);
                break;
            case "2":
                newGoal = new EternalGoal(goalName, description, points);
                break;
            case "3":
                Console.Write("How many times to complete? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(goalName, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid option.");
                return;
        }

        _goals.Add(newGoal);
        Console.WriteLine("Goal created successfully!");
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish?");
        ListGoalNames();
        Console.Write("Enter the goal number: ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < _goals.Count)
        {
            Goal selectedGoal = _goals[choice];
            int earned = selectedGoal.RecordEvent();
            _score += earned;
            Console.WriteLine($"Well done! You earned {earned} points.");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Enter file name to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("Enter file name to load: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            Console.WriteLine($"Loading from: {Path.GetFullPath(filename)}");
            string[] lines = File.ReadAllLines(filename);
            _score = int.Parse(lines[0]);
            _goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                Goal goal = GoalFactory.CreateGoalFromString(line);
                _goals.Add(goal);
            }

            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}