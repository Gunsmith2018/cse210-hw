public class MathAssignment2 : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";


    public MathAssignment2()
    {
        _textbookSection = "BETA2";
        _problems = "BETA2";         // These will need editing to pass varaibles through

    }
    public MathAssignment2(string booksection, string problems) : base(studentName)
    {
        _textbookSection = booksection;
        _problems = problems;         // These will need editing to pass varaibles through

    }

    public string GetHomeworkList()
    {
        return $"{_studentName} and {_topic} {_textbookSection} {_problems}";
    }



}