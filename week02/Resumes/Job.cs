using System;


public class Job 
{
    //Attributes
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    //Methods
    public void DisplayJob()
    {
        Console.WriteLine($"{_jobTitle} ({_company})  {_startYear}-{_endYear}");
    }
}