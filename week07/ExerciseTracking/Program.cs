using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Create activities
        Running running = new Running("03 Nov 2022", 30, 4.8);
        Cycling cycling = new Cycling("03 Nov 2022", 45, 20.0);
        Swimming swimming = new Swimming("03 Nov 2022", 30, 40);

        //Add activities to a list
        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        //Show the summary of each activity
        foreach(Activity activity in activities)
        {
            Console.WriteLine($"\n{activity.GetSummary()}\n");
        }
    }
}