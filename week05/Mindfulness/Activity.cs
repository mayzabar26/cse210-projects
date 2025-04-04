using System;
using System.Threading;
using System.Collections.Generic;

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


    //Setting Getter and Setter for duration
    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration; //Allows us to modify _duration safely
    }


    //Setting the Method: DisplayStartingMessage()
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nWelcome to the {_name}!");
        Console.WriteLine($"\n{_description}");
        Console.Write("\nHow long, in seconds, would you like for your session? ");

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

        Console.WriteLine("\nGet ready to start...");
        ShowSpinner(3);
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