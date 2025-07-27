public class Word
{

    private string _text = "";

    public Word()
    {
        _text = "";// Constructor
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
        return _text;
    }

}