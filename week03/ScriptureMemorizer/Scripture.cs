using System;
using System.Collections.Generic;
using System.Linq;

class Scripture 
{
    //Attributes
    private Reference _reference;
    private List<Word> _words;


    //Constructor: Receive text and verse reference
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ') //Divide text into words
                     .Select(word => new Word(word)) //Create an object for each word
                     .ToList(); //Convert to a list
    }


    //Method 01: Hide random words
    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            //Select only visible words
            var visibleWords = _words.Where(word => !word.IsHidden()).ToList();

            //If all words are hidden, loop stops
            if (visibleWords.Count == 0)
                break;

            //Choose a random word from the list to hide
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();

            hiddenCount++;
        }
    }


    //Method 02: Return verse with hidden words
    public string GetDisplayText()
    {
        return _reference.GetDisplayText() + " " +
               string.Join(" ", _words.Select(word => word.GetDisplayText()));
    }


    //Method 03: Verify if all words are hidden
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}