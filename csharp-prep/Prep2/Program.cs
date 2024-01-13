using System;

class Program
{
    static void Main(string[] args)
    {

        string letter = "";


        Console.Write("What is your grade percentage? ");
        string value = Console.ReadLine();

        float gradePercent = float.Parse(value);

        if (gradePercent >= 90)
        {
            letter = "A";
        }

        else if (gradePercent < 90 && gradePercent >= 80)
        {
            letter = "B";
        }

        else if (gradePercent < 80 && gradePercent >= 70)
        {
            letter = "C";
        }

        else if (gradePercent < 70 && gradePercent >= 60)
        {
            letter = "D";
        }

        else if (gradePercent < 60)
        {
            letter = "F";
        }

        else
        {
            Console.WriteLine("Please try again with a valid percentage");
        }


       
        if (gradePercent > 70)
        {
            Console.WriteLine($"Congrates! You got a {letter} and passed the class:)");
        }

        else
        {
            Console.WriteLine($"You got a {letter} and you didn't pass. Keep trying :)");
        }


        
    }
}