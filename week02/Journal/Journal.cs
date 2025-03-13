using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    // Attributes: A list to store all journal entries
    private List<Entry> _entries = new List<Entry>();


    //Method 01: Add an entry to the journal
    public void AddEntry(string prompt, string response)
    {
        //Store date and time
        //Showing Creativity: I'm storing not just the date but also the time.
        string date = DateTime.Now.ToString("MM-dd-yyyy HH:mm");

        //Create a new Entry object and add it to the list
        _entries.Add(new Entry(date, prompt, response)); 

    }


    //Method 02: Show all entries
    public void DisplayEntries()
    {
        //Showing Creativity: Using if statement to show message if the program doens't find any entries 
        //If there isn't any entries, display the message
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        Console.WriteLine("\n===== Journal Entries =====");

        //Loop through the list and show each entry (will show all entries with date and time)
        foreach (var entry in _entries)
        {
             Console.WriteLine(entry.getFormattedEntry());
        }
    }


    //Method 03: Save entries to file (How the entries will be save in the file?)
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry.Date);
                writer.WriteLine(entry.Prompt);
                writer.WriteLine(entry.Response);
                writer.WriteLine(); // Blank line as a separator
            }
        }
        Console.WriteLine($"Journal saved to {filename}");
    }


    //Method 04: Load from file
    public void LoadFromFile(string filename)
    {
        //Verify if the file exists
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        for (int i = 0; i < lines.Length; i += 4) // Read entries in sets of 3 (plus a blank line)
        {
            if (i + 2 < lines.Length) // Ensure we have enough lines
            {
                string date = lines[i];
                string prompt = lines[i + 1];
                string response = lines[i + 2];

                _entries.Add(new Entry(date, prompt, response));
            }
        }
        Console.WriteLine($"Journal loaded from {filename}");
    }
}