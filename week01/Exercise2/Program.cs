using System;

class Program
{
    static void Main(string[] args)
    {
        //Asking the user about their score
        Console.Write("What is your grade percentage? ");
        string score = Console.ReadLine();

        //Using tryparse to motify the string to a number
        if (int.TryParse(score, out int number))
        {

            //Condition
            if (number >= 90)
            {
                Console.WriteLine("Congrats. You got an A!");
            }
            else if (number >= 80)
            {
                Console.WriteLine("Congrats. You got an B!");
            }
            else if (number >= 70)
            {
                Console.WriteLine("Congrats. You got a C!");
            }
            else if (number >= 60)
            {
                Console.WriteLine("You passed, but you need to improve. You got a D.");
            }
            else
            {
                Console.WriteLine("You didn't pass. Better luck next time.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

    }
}