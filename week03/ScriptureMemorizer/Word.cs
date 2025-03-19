using System;

public class Word 
{
    //Attributes
    private string _text;
    private bool _isHidden;


    //Constructor: Starts the verse with all the words visible
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    //Method 01: Hides the word
    public void Hide()
    {
        _isHidden = true;
    }


    //Method 02: Shows the word
    public void Show()
    {
        _isHidden = false;
    }


    //Method 03: Check if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }


    //Method 04:
    public string GetDisplayText()
    {
        if (_isHidden)
            return new string('_', _text.Length); //Word is be replaced by '_'
        else
            return _text;
    }



}