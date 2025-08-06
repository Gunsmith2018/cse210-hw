using System;

class Program

{
    private string TitleArt = "=== Mindfullness Beta ===";
    private BreathingActivity breathing = new BreathingActivity();
    private ListingActivity listing = new ListingActivity();
    private ReflectingActivity reflecting = new ReflectingActivity();
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
                    breathing.run();
                    break;
                case "2":
                    listing.run();
                    break;
                case "3":
                    reflecting.run();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1–4.");
                    break;
            }
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }

    private string GetChoice()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(TitleArt);
        Console.ForegroundColor = ConsoleColor.Black;

        Console.WriteLine("\nWelcome! What activity would you like to do?");
        Console.WriteLine(" > 1 - Breathing Activity.");
        Console.WriteLine(" > 2 - Lisitng Activity");
        Console.WriteLine(" > 3 - Reflecting Activity");

        return Console.ReadLine(); // Get user input
    }





    /*
        // ================== Breathing Activity ===================//

        // ================== Breathing Activity ===================//


        // ================== Listing Activity ===================//
        ListingActivity activity = new ListingActivity(
        "Mindful Moment", "Reflection time", "5 minutes",
        "What went well?,What challenged you?"
        );
        // ================== Listing Activity ===================//

        // ================== reflecting Activity ===================//
        ReflectingActivity activity2 = new ReflectingActivity(
        "Mindful Moment", "Reflection time", "5 minutes",
        "What went well?,What challenged you?",
        "Why did it go well?,How did you respond?"
        );
        // ================== Reflecting Activity ===================//
        */

}

