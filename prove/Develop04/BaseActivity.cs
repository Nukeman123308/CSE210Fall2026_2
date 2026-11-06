using System.ComponentModel;

class BaseActivity
{

    // Add Atributes
    public BaseActivity()
    {
        // TODO Fill in 
    }

    public void RunCountDownMessage(string message, int seconds)
    {
        Console.CursorVisible = false; 
        for(int i=0; i<seconds; i++)
        {
            Console.Clear(); 
            Console.Write($" {message} - {i}"); 
            Thread.Sleep(1000); 
        }
        Console.CursorVisible = true; 


    }

    public void DisplaySpinnerMessage(string message, int seconds) 
    {
        Console.Write($"{message}" );  
        for (int i=0; i < seconds; i++)
        {
            Console.Write("+");
            Thread.Sleep(200); 
            Thread.Sleep(1000); 
            Console.Write("\b"); 
            Console.Write("-"); 
            Thread.Sleep(200);
            Console.Write("\b");

        }
        Console.CursorVisible = true; 

        
    }




}