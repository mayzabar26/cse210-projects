using System;

public class BreathingActivity : Activity
{
    //Setting the Method: BreathingActivity()
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    //Main activity method
    public override void Run()
    {
        DisplayStartingMessage();

        int elapsedTime = 0;
        int duration = GetDuration();

        while (elapsedTime < duration)
        {
            Console.WriteLine("\nBreathe in... ");
            ShowCountDown(4);

            Console.WriteLine("\nNow, Breathe out... ");
            ShowCountDown(6);

            elapsedTime += 10; //Each cicle takes 10 seconds
        }

        DisplayEndingMessage();
    }
}