using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please tell me your first name: ");
        string first = Console.ReadLine();

        Console.Write("Please tell me your last name: ");
        string last = Console.ReadLine();

        Console.WriteLine($" Your name is {last}, {first} {last} ");

    }
}