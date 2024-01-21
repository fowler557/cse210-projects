using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        

        List<int> numbers = new List<int>();
        
        int userNumber = 0;

        do
        {
        Console.Write("Enter number: ");
        string userEntry = Console.ReadLine();
        userNumber = int.Parse(userEntry);

        numbers.Add(userNumber);

        }while(userNumber != 0);


        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");



        
        float average = ((float)sum)/(numbers.Count);
        Console.WriteLine($"The average is: {average}");



        int largest = 0;
        foreach(int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
            
        }
        Console.WriteLine($"The largest is: {largest}");

    }
}