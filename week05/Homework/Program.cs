using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Assignment assignment1 = new Assignment();
        MathAssignment2 mathAssignment2 = new MathAssignment2();

        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine("---------------------------------------");
        Console.WriteLine(mathAssignment2.GetHomeworkList());

    }
}