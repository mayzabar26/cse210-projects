using System;

public class Resume 
{
    //Attributes
    public string _name; //Resume owner's name
    public List<Job> _jobs = new List<Job>(); //Job's list

    //Methods
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs: ");

        //List in this loop
        foreach (Job job in _jobs)
        {
            //Display the method on each job
            job.DisplayJob();
        }
    }
}