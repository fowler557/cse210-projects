using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "ASI";
        job1._startYear = 2005;
        job1._endYear = 2008;


        Job job2 = new Job();
        job2._jobTitle = "Electrical Engineer";
        job2._company = "Radars inc";
        job2._startYear = 2009;
        job2._endYear = 2023;


        Resume resume = new Resume();
        resume._personName = "Samuel Fowler";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayResume();

    }
}