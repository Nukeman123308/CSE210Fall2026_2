
using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private Random _random = new Random();

    public ListingActivity() : base(
        "Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.WriteLine();

        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        int itemCount = 0;
        string currentAnswer = "";

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        Console.WriteLine("Start listing your answers:");

        Console.Write("> ");

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Enter)
                {
                    if (!string.IsNullOrWhiteSpace(currentAnswer))
                    {
                        itemCount++;
                    }

                    currentAnswer = "";
                    Console.WriteLine();

                    if (DateTime.Now < endTime)
                    {
                        Console.Write("> ");
                    }
                }
                else if (key.Key == ConsoleKey.Backspace)
                {
                    if (currentAnswer.Length > 0)
                    {
                        currentAnswer = currentAnswer.Substring(
                            0, currentAnswer.Length - 1);

                        Console.Write("\b \b");
                    }
                }
                else if (!char.IsControl(key.KeyChar))
                {
                    currentAnswer += key.KeyChar;
                    Console.Write(key.KeyChar);
                }
            }
            else
            {
                Thread.Sleep(20);
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {itemCount} items!");

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
