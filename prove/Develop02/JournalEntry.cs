using System;
using System.Collections.Generic;

public class JournalEntry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public void DisplayEntry()
    {
        Console.Write($"{_date}, ");
        Console.WriteLine($"{_promptText}, ");
        Console.WriteLine($"{_entryText}, ");
    }

    public void CreateJournalEntry()
    {

        _date = DateTime.Now.ToShortDateString();


        List<string> prompts = new List<string>()
        {
        "What was the best part of your day?",
        "What was the most challenging part of your day?",
        "What is something you are grateful for today?",
        "Who made a positive difference in your day?",
        "What is something new you learned today?"
        };

        Random random = new Random();
        int index = random.Next(prompts.Count);
        _promptText = prompts[index];

        Console.WriteLine(_promptText);
        Console.Write("> ");
        _entryText = Console.ReadLine();

    }








}