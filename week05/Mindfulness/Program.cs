using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        //While loop: keeps running until the user chooses to quit
        while (running)
        {
            Console.WriteLine("\n========== Menu Options ==========");
            Console.WriteLine("\nWelcome to the Activities Program!");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("==================================");
            Console.Write("Select an activity from the menu ");

            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    string randomPrompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {randomPrompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    journal.AddEntry(randomPrompt, response);
                    break;

                case "2": //Display all journal entries
                    journal.DisplayEntries();
                    break;

                case "3": //Load journal entries from a file
                    Console.Write("Enter the filename to load: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;

                case "4": //Save journal entries to a file
                    Console.Write("Enter the filename to save: "); // ✅ Agora pede o nome do arquivo
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;

                case "5": //Quit the program
                    running = false;
                    break;

                default: //Invalid input, show the message
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
        
    }
}