using System;

class Comment
{
    //Setting the variables
    private string _commenter;
    private string _text;


    //Setting constructors
    public Comment(string commenter, string text)
    {
        _commenter = commenter;
        _text = text;
    }    


    //Setting method: DisplayComment()
    public void DisplayComment()
    {
        Console.WriteLine($"Commentor: {_commenter}");
        Console.WriteLine($"Comment: {_text}\n");
    }
}

