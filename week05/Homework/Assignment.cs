public class Assignment
{
    protected string _studentName = "";
    protected string _topic = "";


    public Assignment() // Constructor
    {
        _studentName = "BETA"; // Use this rather than Getters and Setters to pass new 
        _topic = "BETA";             // varaibles into private strings

    }
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    public string GetSummary()
    {
        return $"{_studentName} and {_topic}";
    }



}