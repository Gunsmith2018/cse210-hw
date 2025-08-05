public class Activity // This is the Base or Parent class. 
{
    // ================ Strings ==========================
    protected string _name = "";
    protected string _description = "";
    protected string _duration = "";
    // ================= Functions =======================
    public Activity() // Constructors
    {
        _name = "";
        _description = "";
        _duration = "";
    }
    public Activity(string name, string description, string duration) // Constructor
    {
        _name = name;
        _description = description;
        _duration = duration;
    }


    public void DisplayStartingMessage() // Welcome Message 
    {
        Console.WriteLine("Wellcome to the BETA for Mindfullness. ");
    }

    public void DisplayEndingMessage() // Good Bye Message
    {
        Console.WriteLine("Thank you for using Mindfullness BETA.");
    }

    public void ShowSpinner(int seconds)  //
    {

    }

    public void ShowCountDown(int seconds) //
    {

    }




}