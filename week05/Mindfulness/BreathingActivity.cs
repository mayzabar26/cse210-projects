//using System;

public class BreathingActivity : Activity
{
    //Setting the Method: BreathingActivity()
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    //Main activity method
    public override void Run()
    {
        DisplayStartingMessage(); //Will display starting message

        int elapsedTime = 0; //Activity time duration starts in 0
        int duration = GetDuration(); //User time duration

        //Breathing instructions based on user time duration
        while (elapsedTime < duration)
        {
            Console.WriteLine("\nBreathe in... ");
            ShowCountDown(4);

            Console.WriteLine("\nNow, Breathe out... ");
            ShowCountDown(6);

            elapsedTime += 10; //Each cicle takes 10 seconds
        }

        DisplayEndingMessage(); //Will display ending message
    }
}