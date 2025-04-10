using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        int choice = 0;
        while (choice != 8)
        {
            Console.Clear();
            Console.WriteLine("Eternal Quest Program");
            Console.WriteLine("======================");
            Console.WriteLine($"Current Score: {goalManager.GetScore()}\n");

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Display Player score"); //Creativity: adding option to show the score
            Console.WriteLine("2. List Goal Names"); //Creativity: adding option to show the goal details
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create New Goal");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Record Event");
            Console.WriteLine("8. Quit");
            Console.Write("Select a choice from the menu: ");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                Console.Clear();

                switch (choice)
                {
                    case 1:
                        goalManager.DisplayPlayerInfo();
                        break;
                    case 2:
                        goalManager.ListGoalNames();
                        break;
                    case 3:
                        goalManager.ListGoalDetails();
                        break;
                    case 4:
                        goalManager.CreateGoal();
                        break;
                    case 5:
                        goalManager.SaveGoals();
                        break;
                    case 6:
                        goalManager.LoadGoals();
                        break;
                    case 7:
                        goalManager.RecordEvent();
                        break;
                    case 8:
                        Console.WriteLine("Thanks for playing Eternal Quest! Goodbye.");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }

                if (choice != 8)
                {
                    Console.WriteLine("\nPress Enter to continue...");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        } 
    }
}