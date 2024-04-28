using System;

class Program
{
    static void Main(string[] args)
    {
        //Calling DisplayWelcome function
        DisplayWelcome();

        //Calling PromptUserName function
        String userName = PromptUserName();

        //Calling PromptUserNumber function
        int userNumber = PromptUserNumber();

        //Calling SquareNumber function
        int squaredNumber = SquareNumber(userNumber);

        //Calling DisplayResult function
        DisplayResult(userName, squaredNumber);
    }

    //DisplayWelcome Function
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    //PromptUserName Function
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    //PromptUserNumber Function
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    //SquareNumber Function
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    //DisplayResult Function
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name} the square of your number is {square}.");
    }
}