using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Prompts promptGenerator = new Prompts();
        bool running = true;


        //While loop: keeps running until the user chooses to quit
        while (running)
        {
            //Display the menu and showing creativity
            Console.WriteLine("\n========== Journal Menu ==========");
            Console.WriteLine("\nWelcome to the Journal Program!");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("==================================");
            Console.Write("What would you like to do? ");
            
            string choice = Console.ReadLine();

            switch (choice)
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