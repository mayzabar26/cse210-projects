using System;
using System.Threading;

public abstract class Activity 
{
    //Setting the variables
    private string _name;
    private string _description;
    private int _duration;


    //Setting constructors
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }


    //Setting the Method: DisplayStartingMessage()
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nWelcome to the {_name}!");
        Console.WriteLine($"\n{_description}");
        Console.Write("How long, in seconds, would you like for your session? ");
        Console.WriteLine("Get ready to start...");

        //Showing creativity: Using if statement in case user has a invalid input. 
        //If we have a invalid input, automatically will set a 30s activity
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            _duration = duration;
        }
        else
        {
            Console.WriteLine("Invalid input. Setting duration to 30 seconds.");
            _duration = 30;
        }
    }


    //Setting the Method: DisplayEndingMessage()
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        Console.WriteLine($"You completed {_duration} seconds of {_name}");
        ShowSpinner(3);
    }


    //Setting the Method: ShowSpinner()
    public void ShowSpinner(int seconds)
    {
        for(int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }


    //Setting the Method: ShowCountDown()
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public abstract void Run();
}