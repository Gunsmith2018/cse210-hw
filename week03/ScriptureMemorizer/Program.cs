using System.IO;
class Program
{
    private string TitleArt = "=== Scripture Mastery ===";
    private Word word = new Word();
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run(); // This will start the menu and flow
    }



    public void Run()
    {
        bool running = true;
        while (running)
        {
            string choice = GetChoice();
            switch (choice)
            {
                case "1":
                    word.GetDisplayText();
                    break;

                case "2":
                    Console.WriteLine("Goodbye!");
                    running = false;
                    break;
            }

        }
    }

    private string GetChoice()
    {
        Console.Clear();
        Console.WriteLine(TitleArt);

        Console.WriteLine("Press 1 to beguin or press 2 to end");

        return Console.ReadLine();
    }


    //Console.WriteLine(word.GetDisplayText());




}
