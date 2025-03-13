using System;
using System.Collections.Generic;
using System.IO;

public class Prompts
{
    //Attributes: List of questions (Random Prompts)
    private List<string> _prompts = new List<string> 
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    //Method: GetRandomPrompts()
    public string GetRandomPrompt()
    {
        Random random = new Random(); //Creates a new random object
        int index = random.Next(_prompts.Count); //Will choose a random index
        return _prompts[index]; //Returns the random selected prompt
    }

}