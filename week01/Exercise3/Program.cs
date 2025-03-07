using System;
using System.Globalization;
using System.Net;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        //Step 1: Welcome user to the game
        Console.WriteLine("Hello! Welcome to the Magic Number Game.");
        
        //Step 2: Generate a random number between 1 and 100
        Random randomGenerator = new Random(); 
        int randomNumber = randomGenerator.Next(1, 101); //Variable to store user number

        //Step 3: Variable to store user's number
        int guess;
        
        //Step 4: Condition using do-while loop and if statement
        do 
        {
            //Asking user what's their guess
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            //Verify if the guess needs to be higher, lower or igual to magic number.
            if (randomNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (randomNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != randomNumber); //Loop keeps on until the user guess the number

    }
}