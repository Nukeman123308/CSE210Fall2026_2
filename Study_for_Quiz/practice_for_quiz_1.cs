using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your height in inches: "); 
        string input = Console.ReadLine(); 

        int num = int.Parse(input); 
        Console.WriteLine($"Your height is {num} inches. "); 

        if (num < 48)
        {
            Console.WriteLine("You are to short.");
        }

        else if (num > 78)
        {
            Console.WriteLine("You are to tall.");
        }

        else
        {
            Console.WriteLine("You are the right height. "); 
        }

    }
}


