
using System;

public class Word
{
    private string _word;
    private bool _hidden;

    // Constructor: creates a word that is initially visible
    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    // Hides the word
    public void Hide()
    {
        _hidden = true;
    }

    // Shows the word again
    public void Show()
    {
        _hidden = false;
    }

    // Checks whether the word is hidden
    public bool IsHidden()
    {
        return _hidden;
    }

    // Displays the word or its underscores
    public void Display()
    {
        Console.Write(GetWordString());
    }

    // Returns the word or underscores as a string
    public string GetWordString()
    {
        string returnString = "";

        if (_hidden)
        {
            for (int i = 0; i < _word.Length; i++)
            {
                returnString += '_';
            }
        }
        else
        {
            returnString = _word;
        }

        return returnString;
    }
}
