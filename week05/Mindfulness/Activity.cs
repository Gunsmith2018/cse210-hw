public class Activity // This is the Base or Parent class. 
{
    // ================ Strings ==========================
    protected string _name = "";
    protected string _description = "";
    protected string _duration = "";


    // ================= Constructors =======================
    public Activity()
    {
        _name = "BASE BETA";
        _description = "BASE BETA";
        _duration = "BASE BETA";
    }
    public Activity(string name, string description, string duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    // ================= Functions =======================
    public void DisplayStartingMessage() // Welcome Message 
    {
        Console.WriteLine("Wellcome to the BETA for Mindfullness. ");
    }

    public void DisplayEndingMessage() // Good Bye Message
    {
        Console.WriteLine("Thank you for using Mindfullness BETA.");
    }

    public void ShowSpinner(int seconds)  // spinner or throbber
    {
        {
            List<string> animationString = new List<string>();
            animationString.Add("|");
            animationString.Add("/");
            animationString.Add("-");
            animationString.Add("\\");
            animationString.Add("|");
            animationString.Add("/");
            animationString.Add("-");
            animationString.Add("\\");


            foreach (string s in animationString)
            {
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

        }
    }

    public void ShowCountDown(int seconds) // Count Down
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }




}