using System;

public class Resume
{
    //Responsibilities 
    public string _personName = "";
    public List<Job> _jobs = new List<Job>();


    // Methods Displays the resume, which shows the name first, 
// followed by displaying each one of the jobs.
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Jobs: ");

        foreach (Job j in _jobs)
        {
            j.DisplayJobInfo();
        }
    }
}