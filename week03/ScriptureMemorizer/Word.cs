using System.Runtime.CompilerServices;

public class Word
{

    Scriptures scriptures = new Scriptures();

    private string _text = "";

    public Word()
    {
        _text = scriptures.GetRandomScripture();// Constructor
    }
    public Word(string text)
    {
        _text = text;
    }



    public void ConvertHidden()
    {
        string hidden = "";

        foreach (var c in _text)
        {
            hidden += "_";

        }
        _text = hidden;
    }

    public string GetDisplayText()
    {
        Console.WriteLine($"{_text}");

    }

}