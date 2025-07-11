using System;

public class Journal
{

    // This will save the user input into a text file.
    public void AddToJournal()
    {
        PromptGenerator generator = new PromptGenerator();
        Console.WriteLine(generator.GetRandomPrompt());
        Console.Write("Enter your Journal Entry: ");
        string entryText = Console.ReadLine();

        string timestamp = DateTime.Now.ToString("yyyy-MM-dd"); // Format: 2025-07-11
        string formattedEntry = $"Date: {timestamp}\nEntry: {entryText}\n---\n";

        File.AppendAllText("journal.txt", formattedEntry + Environment.NewLine);
        Console.WriteLine("Entry saved!");

    }
    // This will see if there is a file avalible to open.
    public void ReadJournal()
    {
        if (File.Exists("journal.txt"))
        {
            string content = File.ReadAllText("journal.txt");
            Console.WriteLine("\nYour journal:\n" + content);
        }
        else
        {
            Console.WriteLine("Journal File Not Found.");
        }
    }
    // This will delete the file the user doesn't want.
    public void ClearJournal()
    {
        if (File.Exists("journal.txt"))
        {
            File.Delete("journal.txt");
            Console.WriteLine("Journal Deleted.");
        }
        else
        {
            Console.WriteLine("No journal to delete. ");
        }
    }


}




