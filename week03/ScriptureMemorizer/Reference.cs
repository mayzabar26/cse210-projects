using System;

public class Reference 
{
    //Attributes
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    //First Construtor: Single verse
    public Reference(string book, int chapter, int verse) 
    {
        _book = book;
        _chapter = chapter;
        _verse = verse; 
        _endVerse = verse;
    }


    //Second Construtor: Multiple verses
    public Reference(string book, int chapter, int verse, int endVerse) 
    {
        _book = book;
        _chapter = chapter;
        _verse = verse; 
        _endVerse = endVerse;
    }


    //Method 01: GetDisplayText
    public string GetDisplayText()
    {
        if (_verse == _endVerse)
            return $"{_book} {_chapter} {_verse}"; 
        else
            return $"{_book} {_chapter} {_verse} {_endVerse}";
    }
    
}