using System.Dynamic;

public class ListingActivity
{
// ================== Strings =====================================
    private string[] _count = new string[]
    {

    };
    private string[] _prompt = new string[]
    {
//====================== Functions ============================
    };

    public ListingActivity() // Constructor
    {

    }

    public void DisplayPrompt() 
    {
        foreach (string prompt in _prompt)
        {
            Console.WriteLine(prompt);
        }
    }

    public string GetrandomPrompt() // Gets Random Prompt
    {
        Random rand = new Random();
        int index = rand.Next(_prompt.Length);
        return _prompt[index];
    }



    public void AddingToList() // Saving user entries to listing.txt
    {

        Console.WriteLine(GetrandomPrompt());
        Console.Write("Please Enter Your Thoughts: ");
        
        string entryText = Console.ReadLine();

        string timestamp = DateTime.Now.ToString("yyyy-MM-dd"); // Format: 2025-07-11
        string formattedEntry = $"Date: {timestamp}\nEntry: {entryText}\n---\n";

        File.AppendAllText("listing.txt", formattedEntry + Environment.NewLine);
        Console.WriteLine("Entry saved!");
    }

    public void GetListFromUser() // Reading user's entry
    {
        if (File.Exists("listing.txt"))
        {
            string content = File.ReadAllText("listing.txt");
            Console.WriteLine("\nHere is your entry:\n" + content);
        }
        else
        {
            Console.WriteLine("Entry Not Found.");
        }
    }

    public void ClearList() // Deleting the user's entries
    {
        if (File.Exists("listing.txt"))
        {
            File.Delete("listing.txt");
            Console.WriteLine("Your Entries have been Deleted.");
        }
        else
        {
            Console.WriteLine("No Entries to Delete. ");
        }
    }

    public void run() // Run's Listing Activity Program
    {

    }

}