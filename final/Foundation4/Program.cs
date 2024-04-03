using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating activity instances
        Activity running = new Running(new DateTime(2022, 11, 03), 30, 4.8);
        Activity cycling = new Cycling(new DateTime(2022, 11, 03), 45, 20);
        Activity swimming = new Swimming(new DateTime(2022, 11, 03), 30, 20);

        // Adding activities to a list
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Displaying activities summary
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
 