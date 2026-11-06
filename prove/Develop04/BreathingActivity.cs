
using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int remaining = GetDuration();

        while (remaining > 0)
        {
            int breatheIn = Math.Min(3, remaining);

            Console.Write("Breathe in... ");
            ShowCountDown(breatheIn);
            Console.WriteLine();

            remaining -= breatheIn;

            if (remaining > 0)
            {
                int breatheOut = Math.Min(3, remaining);

                Console.Write("Breathe out... ");
                ShowCountDown(breatheOut);
                Console.WriteLine();

                remaining -= breatheOut;
            }
        }

        DisplayEndingMessage();
    }
}
