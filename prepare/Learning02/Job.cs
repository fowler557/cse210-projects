using System;


public class Job
{
    //Attributes
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;


    //Methods "Job Title (Company) StartYear-EndYear", for example: "Software Engineer (Microsoft) 2019-2022
    public void DisplayJobInfo()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}