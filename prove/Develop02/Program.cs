using System;
using System.IO;

// Creativity:
// I added a feature that counts the total number of journal entries.
// I also made the program automatically add .txt to filenames
// when saving or loading journal entries.


class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();
        Journal myJournal = new Journal();
        int response = 0;

        while (response != 5)
        {
            response = myMenu.ProcessMenu();
            switch (response)
            {

                case 1:
                    JournalEntry newEntry = new JournalEntry();
                    newEntry.CreateJournalEntry();
                    myJournal.AddEntry(newEntry);
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Your Journal Entries:");
                    myJournal.DisplayAll();
                    Console.WriteLine($"Total journal entries: {myJournal.GetEntryCount()}");
                    break;

                case 3:
                    Console.Write("Enter filename: ");
                    string filename = Console.ReadLine();
                    if (!filename.EndsWith(".txt"))
                    {
                        filename += ".txt";
                    }
                    myJournal.SaveToFile(filename);
                    Console.WriteLine("Journal saved successfully!");
                    break;


                case 4:
                    Console.Write("Enter filename to load: ");
                    string loadFilename = Console.ReadLine();

                    if (!loadFilename.EndsWith(".txt"))
                    {
                        loadFilename += ".txt";
                    }

                    if (File.Exists(loadFilename))
                    {
                        myJournal.LoadFromFile(loadFilename);
                        Console.WriteLine("Journal loaded successfully!");
                    }
                    else
                    {
                        Console.WriteLine("File not found.");
                    }
                    break;



            }
        }
    }
}