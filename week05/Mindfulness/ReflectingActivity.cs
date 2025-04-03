public class ReflectingActivity : Activity 
{
    //Setting the variables
    private List<String> _prompts;
    private List<String> _questions;


    //Setting constructors
    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    //Setting Getters
    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }


    private string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
    }


    //Main activity method
    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("\nTake a few moments to reflect on this.");
        ShowSpinner(5);

        int elapsedTime = 0;
        int duration = GetDuration();

        while (elapsedTime < duration)
        {
            Console.WriteLine($"\n{GetRandomQuestion()}");
            ShowSpinner(5);
            elapsedTime += 5;
        }

        DisplayEndingMessage();
    }
}