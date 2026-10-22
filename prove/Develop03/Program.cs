
using System;

class Program
{
    static void Main(string[] args)
    {
        // Creativity:
        // My program only selects words that are not already hidden.
        // This makes sure new words disappear every time the user
        // presses Enter instead of selecting previously hidden words.

        // Create the scripture reference
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        // Store the scripture text
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        // Create the Scripture object
        Scripture scripture = new Scripture(reference, text);

        // Keep running until the user quits or all words are hidden
        while (true)
        {
            Console.Clear();

            // Display the scripture
            scripture.ShowScripture();

            // Check if all words are hidden
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine();
                Console.WriteLine("All words are hidden! Great job!");
                break;
            }

            // Ask the user what to do
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine() ?? "";

            // Exit if the user types quit
            if (input.Trim().Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            // Hide three random words
            if (input == "")
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.WriteLine("Thank you for practicing!");
    }
}
