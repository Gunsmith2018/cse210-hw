/* Deals with the selection Choices*/


 public class Entry
{
    public string Date { get; private set; }
    public string PromptText { get; private set; }
    public string EntryText { get; private set; }

    public Entry()
    {
        WelcomeMessage();
        Date = GetDate();
        PromptText = GetPrompt();
        EntryText = GetEntry();
    }
    // This is a welcome message
    public void WelcomeMessage()
    {
        Console.WriteLine("Welcome to Journal Beta! ");
    }

    // This will store the date
    public string GetDate()
    {
        Console.Write("Please tell me the date: ");
        return Console.ReadLine();
    }
    public string GetPrompt()
    {
        PromptGenerator promptGen = new PromptGenerator();
        string prompt = promptGen.GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        return prompt;
    }
    // The user will input their thoughts
    private string GetEntry()
    {
        Console.Write("Please input your thoughts: ");
        return Console.ReadLine();
    }

    public string FormatForSaving()
    {
        return $"Date: {Date}\nPrompt: {PromptText}\nEntry: {EntryText}\n---\n";
    }

}