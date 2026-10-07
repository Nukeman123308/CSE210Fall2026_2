using System;


public class JournalEntry
{
    public string _date; 
    public string _promtText;
    public string _entryText; 
    public void DisplayEntry()
    {
        Console.Write($"{_date}, "); 
        Console.WriteLine($"{_promtText}, "); 
        Console.WriteLine($"{_entryText}, "); 
    }

    public void CreateJournalEntry()
    {
        _date = "October 7, 2026";
        _promtText = "How was your day?"; 

        Console.Write($"{_promtText}");
        _entryText = Console.ReadLine(); 

    }








}