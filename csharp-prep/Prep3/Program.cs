using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        //Asking for the magic number and the user's guess number
        Console.Write("What is your magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());

        //Random number generator
        Random randomGenerator = new Random();
        magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        //While Loops here
        while (guess != magicNumber)
        {
            Console.Write("Whats is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}        