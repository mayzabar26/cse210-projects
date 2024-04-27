using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Console.Write("What is the magic number? ");
        string magicNumber = Console.ReadLine();
       
        Console.Write("What is your guess? ");
        string guessNumber = Console.ReadLine();


        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
       

    }
}