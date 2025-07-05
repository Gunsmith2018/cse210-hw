using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {

        welcomemessage();
        string name = username();
        int inputnumber = usernumber();
        int squarednumber = square(inputnumber);
        results(name, squarednumber);

        void welcomemessage()
        {
            Console.WriteLine("Welcome to a simple program with functions.");
        }

        string username()
        {
            Console.Write("Please tell me your name: ");
            string name = Console.ReadLine();
            return name;
        }

        int usernumber()
        {
            Console.Write("Please give me a number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }
        int square(int number)
        {
            int square = number * number;
            return square;
        }

        void results(string name, int squarednumber)
        {
            Console.WriteLine($"{name}, the square of your number is {square} ");

        }

    }
}