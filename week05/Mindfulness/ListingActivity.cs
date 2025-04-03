using System;
using System.Collections.Generic;

public class ListingActivity : Activity 
{
    //Setting the variables
    private List<String> _prompts;


    //Setting constructors
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }


    //Setting the Method: GetRandomPrompt()
    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }


    //Main activity method 
    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"----- {GetRandomPrompt()} -----");
        
        Console.WriteLine("\nYou have a few seconds to think before starting...");
        ShowSpinner(5);
        
        int elapsedTime = 0;
        int duration = GetDuration();
        List<String> responses = new List<string>();
        
        Console.WriteLine("\nStart listing your response:");

        while (elapsedTime < duration)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            responses.Add(response);
            elapsedTime += 5; 
        }
        Console.WriteLine($"You listed {responses.Count} items!");
        DisplayEndingMessage();
    }
}