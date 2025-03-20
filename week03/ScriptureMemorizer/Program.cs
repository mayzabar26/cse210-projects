using System;

class Program
{
    static void Main(string[] args)
    {
        //Verse reference
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        //Reference with text
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own un understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        

        while (true)
        {
            Console.Clear(); //Cleans the terminal
            Console.WriteLine(scripture.GetDisplayText()); //Shows the verse

            //If all words are hidden, quit the program
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden. Scripture memorizer is complete!");
                break;
            }

            Console.Write("\nPress enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
               break;

            scripture.HideRandomWords(2); //Hides 2 words each time.
        }
    }
}