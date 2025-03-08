using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();

        int favoriteNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(favoriteNumber);

        DisplayResult(userName, squaredNumber);

    }

    //First function: Welcome Function
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    //Second function: User's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    //Third function: Favorite Number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    //Fourth function: Square Number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    //Fifth function: Result
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.Write($"{name}, the square of your number is {squaredNumber}");
    }
}