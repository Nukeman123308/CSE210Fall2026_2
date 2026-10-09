using System.Collections.Generic;
using System.IO;


public class Journal
{
    public List<JournalEntry> _entries = new List<JournalEntry>();

    public void AddEntry(JournalEntry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {

        foreach (JournalEntry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }


    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {

            foreach (JournalEntry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }

        }
    }



    public void LoadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);

        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            JournalEntry entry = new JournalEntry();

            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];

            _entries.Add(entry);
        }
    }

    public int GetEntryCount()
    {
        return _entries.Count;
    }



}






