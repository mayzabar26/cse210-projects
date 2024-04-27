using System;

class Program
{
    static void Main(string[] args)
    {
        //Asking for first name and last name
        Console.WriteLine("Hello Prep1 World!");
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();
        Console.WriteLine();

        //Sentence's output 
        Console.WriteLine($"Your name is {last}, {first} {last}.");
        Console.WriteLine();
    }
}