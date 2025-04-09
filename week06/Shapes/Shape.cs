using System;

public abstract class Shape 
{
    //Set the Variables
    private string _color;


    //Set the Construtor
    public Shape (string color) 
    {
        _color = color;
    }


    //Set the Getters and setters
    public string GetColor()
    {
        return _color;
    }


    public void SetColor(string color)
    {
        _color = color;
    }


    //Set the Method
    public abstract double GetArea();
}