//using System;
//using System.Collections.Generic;
public class ReflectingActivity : Activity 
{
    //Declare static Random instance to prevent duplicate values
    private static Random _rand = new Random();


    //Setting the variables
    private List<String> _prompts;
    private List<String> _questions;


    //Setting constructors with list of prompts and questions
    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    //Setting Getters GetRandomPrompt() and GetRandomQuestion()
    private string GetRandomPrompt()
    {
        return _prompts[_rand.Next(_prompts.Count)]; //Returns random prompts
    }


    private string GetRandomQuestion()
    {
        return _questions[_rand.Next(_questions.Count)]; //Returns random questions
    }


    //Main activity method
    public override void Run()
    {
        DisplayStartingMessage(); //Will display starting message

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("\nTake a few moments to reflect on this.");
        ShowSpinner(7);

        int elapsedTime = 0;
        int duration = GetDuration();

        while (elapsedTime < duration)
        {
            Console.WriteLine($"\n{GetRandomQuestion()}");
            ShowSpinner(5); //Gives the user time to think about the answer
            elapsedTime += 5;  //Each question takes 5 seconds
        }

        DisplayEndingMessage(); //Will display ending message
    }
}