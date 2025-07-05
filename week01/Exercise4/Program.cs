using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {

    List<int> numbers;
    numbers = new List<int>();

    int user = -1;
        while (user != 0)
        {
            Console.Write("Please enter a number. When you are done please enter (0): ");

            string Response = Console.ReadLine();
            user = int.Parse(Response);
            if (user != 0)
            {
                numbers.Add(user);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($" The current sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");

    }
}