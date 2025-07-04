using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != number)
            {
                Console.Write("Please guess a number:  ");
                guess = int.Parse(Console.ReadLine());

                if (number > guess)
                {
                    Console.WriteLine("Try hiher ");
                }
                else if (number < guess)
                {
                    Console.WriteLine("Try lower");
                }
                else
                {
                    Console.WriteLine("You guessed it! ");
                }


            }


    }
}