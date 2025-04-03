using System;

class Assignment 
{
    //Setting the variables
    private string _studentName;
    private string _topic;

    //Setting constructors
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    //Setting the Getter to access the private attributes
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}