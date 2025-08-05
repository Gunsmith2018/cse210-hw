using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

public class ReflectingActivity
{

    private string[] _prompts = new string[]
    {
        
    };
    private string[] _questions = new string[]
    {

    };


    public ReflectingActivity()
    {

    }

    public void DisplayPrompt()
    {
        foreach (string prompts in _prompts)
        {
            Console.WriteLine(prompts);
        }

    }

        public void DeisplayQuestion()
    {
        foreach (string question in _questions)
        {
            Console.WriteLine(question);
        }
        
    }
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Length);
        return _prompts[index];
    }

    public string GetRandomQUestions()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Length);
        return _questions[index];

    }

    public void AddtoReflectingEntry()
    {
        Console.WriteLine(GetRandomPrompt());
        Console.Write("please enter your thoughts: ");
        //================ There will need to be a question for either getting random prompt or question. =====
        //================ There could also be a random generator that grabs from either prompt or questions. =====
        string entryText = Console.ReadLine();

        string timestamp = DateTime.Now.ToString("yyyy-MM-dd"); // Format: 2025-07-11
        string formattedEntry = $"Date: {timestamp}\nEntry: {entryText}\n---\n";

        File.AppendAllText("reflect_entry.txt", formattedEntry + Environment.NewLine);
        Console.WriteLine("Entry saved!");
    }

        public void ReadJournal()
    {
        if (File.Exists("reflect_entry.txt"))
        {
            string content = File.ReadAllText("reflect_entry.txt");
            Console.WriteLine("\nYour Reflction Entries:\n" + content);
        }
        else
        {
            Console.WriteLine("Entry File Not Found.");
        }
    }
    // This will delete the file the user doesn't want.
    public void ClearJournal()
    {
        if (File.Exists("reflect_entry.txt"))
        {
            File.Delete("reflect_entry.txt");
            Console.WriteLine("Entry Deleted.");
        }
        else
        {
            Console.WriteLine("No Entry to delete. ");
        }
    }



    private void Run()  // Run's Reflecting Program
    {

    }


}