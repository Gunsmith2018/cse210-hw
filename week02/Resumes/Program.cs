using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Nintendo";
        job1._startYear = 2026;
        job1._endYear = 2039;


        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Apple";
        job2._startYear = 1999;
        job2._endYear = 2040;


        Resume R = new Resume();
        R._name = "Aaron Smith";
        R._jobs.Add(job1);
        R._jobs.Add(job2);

        R.DisplayResume();
    }
}