using System;

public class Entry
{
    //Attributes: Will store the entry's date, prompt, and response
    public string Date { get; }
    public string Prompt { get; }
    public string Response { get; }


    //Method 01: Starts an entry with date, prompts and response
    public Entry(string date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }


    //Method 02: Returns getFormattedEntry()
    public string getFormattedEntry()
    {
        return $"{Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }
}