using System;

class Program
{
    static void Main(string[] args)
    {
        //While loop: keeps running until the user chooses to quit
        while (true)
        {
            Console.WriteLine("\n========== Menu Options ==========");
            Console.WriteLine("\nWelcome to the Activities Program!");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("\n==================================");
            Console.Write("Select an activity from the menu: ");

            string userChoice = Console.ReadLine();
            Activity activity = null;

                        
            // Switch case to handle user choice
            switch (userChoice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;

                case "2": 
                    activity = new ReflectingActivity();
                    break;

                case "3":
                    activity = new ListingActivity();
                    break;

                case "4": 
                    Console.Write("\nThank you for using the Mindfulness Program. Goodbye!");
                    return; //Exits the program


                //Showing Creativity and Exceeding Requirements:
                //In case of an invalid choice, the spinner will work for a couple of seconds, and the menu will appear again
                default: //Invalid input, show the message
                    Console.WriteLine("Invalid choice, try again.");
                    ShowSpinner(3);
                    continue; //Goes Back to the menu
            }

            //Runs the selected activity
            activity.Run();

            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey();
        }
        
    }

    //Spinner animation  
    static void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}