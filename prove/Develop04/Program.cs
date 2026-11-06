
using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Creativity: I added counters to track how many times
        // each activity is completed. When the user quits,
        // the program shows a summary of their sessions.

        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;

        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing =
                        new BreathingActivity();
                    breathing.Run();
                    breathingCount++;
                    break;

                case "2":
                    ReflectingActivity reflecting =
                        new ReflectingActivity();
                    reflecting.Run();
                    reflectingCount++;
                    break;

                case "3":
                    ListingActivity listing =
                        new ListingActivity();
                    listing.Run();
                    listingCount++;
                    break;

                case "4":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            if (running)
            {
                Console.WriteLine("\nPress Enter to return to the menu.");
                Console.ReadLine();
            }
        }

        Console.Clear();
        Console.WriteLine("Session Summary:");
        Console.WriteLine($"Breathing activities completed: {breathingCount}");
        Console.WriteLine($"Reflecting activities completed: {reflectingCount}");
        Console.WriteLine($"Listing activities completed: {listingCount}");
        Console.WriteLine("\nThank you for using the Mindfulness Program!");
    }
}
