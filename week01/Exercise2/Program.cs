using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please tell me your grade percentage ");
        string reply = Console.ReadLine();
        int percent = int.Parse(reply);

        string greade_level = "";

        if (percent >= 90)
        {
            greade_level = "A";
        }
        else if (percent >= 80)
        {
            greade_level = "B";
        }
        else if (percent >= 70)
        {
            greade_level = "C";
        }
        else if (percent >= 60)
        {
            greade_level = "D";
        }
        else
        {
            greade_level = "f";
        }

        Console.WriteLine($" Your grade is {greade_level}");

        if (percent >= 70)
        {
            Console.WriteLine("You have passed this course");
        }

        else
        {
            Console.WriteLine("You have failed this course. Please try again. ");
        }

    }
}