
using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description);
        Console.WriteLine();

        while (true)
        {
            Console.Write("How long, in seconds, would you like for your session? ");
            string input = Console.ReadLine() ?? "";

            if (int.TryParse(input, out int seconds) && seconds > 0)
            {
                _duration = seconds;
                break;
            }

            Console.WriteLine("Please enter a positive whole number.");
        }

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed the {_name} for {_duration} seconds.");
        ShowSpinner(3);
        Console.WriteLine();
    }

    protected int GetDuration()
    {
        return _duration;
    }

    protected void ShowSpinner(int seconds)
    {
        string[] symbols = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(symbols[index]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            index = (index + 1) % symbols.Length;
        }
    }

    protected void ShowCountDown(int seconds)
    {
        for (int remaining = seconds; remaining > 0; remaining--)
        {
            string number = remaining.ToString();
            Console.Write(number);
            Thread.Sleep(1000);

            foreach (char digit in number)
            {
                Console.Write("\b \b");
            }
        }
    }
}
