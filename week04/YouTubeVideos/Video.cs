using System;
using System.Collections.Generic;

class Video
{
    //Setting the variables
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments; 


    //Setting constructors
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }


    //Setting method: GetCommentCount()
    //Will count the amount of comments
    public int GetCommentCount()
    {
        return _comments.Count;
    }


    //Setting method: AddComment()
    //Will add a comment to the video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }


    //Setting method: display_info()
    public void DisplayInfo()
    {
        Console.WriteLine($"\nTitle: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length}");
        Console.WriteLine($"Number of comments: {GetCommentCount()}");
        Console.WriteLine("------------------------------");

        if (_comments.Count > 0)
        {
            foreach (Comment comment in _comments)
            {
                comment.DisplayComment();
            }
        }
        else
        {
            Console.WriteLine("No comments yet.");
        }
    }
}