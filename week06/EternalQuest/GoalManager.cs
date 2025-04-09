using System;
using System.Collections.Generic;
using System.IO;


public class GoalManager
{
    //Set Variables
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;


    //Set Constructor
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    

    //Set Methods
    public void Start()
    {
        //Start the program menu loop
        string input = "";

        while (input != "8")
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Display player info");
            Console.WriteLine("2. List goal names");
            Console.WriteLine("3. List goal details");
            Console.WriteLine("4. Create new goal");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Save goals");
            Console.WriteLine("7. Load goals");
            Console.WriteLine("8. Exit");

            Console.Write("Select an option: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    ListGoalNames();
                    break;
                case "3":
                    ListGoalDetails();
                    break;
                case "4":
                    CreateGoal();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    SaveGoals();
                    break;
                case "7":
                    LoadGoals();
                    break;
                case "8":
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
        
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score} points.");
    }
    
    public void ListGoalNames()
    {
        //List only the names of the goals
        Console.WriteLine($"Goal: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }    
    }

    public void ListGoalDetails()
    {
        //Lists goal details, including status and progress
        Console.WriteLine("Goal Details:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
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
        //Register an event on a selected goal
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

    public void SaveGoal()
    {
        //Save goals and score to a file
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
        //Load goals and score from a file
        Console.Write("Enter file name to load: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
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