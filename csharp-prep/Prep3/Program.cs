using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
        //string stringNumber = Console.ReadLine();
        //int number = int.Parse(stringNumber);

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess = 0;

        do
        {
            Console.Write("What is your guess? ");
            string stringGuess = Console.ReadLine();
            guess = int.Parse(stringGuess);

            if (guess > number)
            {
                Console.WriteLine("Lower");
            }

            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (number != guess);
    }
}