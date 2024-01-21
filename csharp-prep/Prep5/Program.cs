using System;

class Program
{
    static void Main(string[] args)
    {
    //returnType FunctionName(dataType parameter1, dataType parameter2)
//{
    // function_body
//}
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program! ");
    }


    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }


   static int PromptUserNumber()
   {
        Console.Write("What is your favorite number? ");
        string userEntryNumber = Console.ReadLine();
        int favoriteNumber = int.Parse(userEntryNumber);
        return favoriteNumber;
   }


    static double SquareNumber(int number)
    {
        double numberSquared = Math.Sqrt(number);
        return numberSquared;

    }


   static void DisplayResult(string userName, double squaredNumber)
   {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
   }


DisplayWelcome();

String userName = PromptUserName();

int userNumber = PromptUserNumber();

double squaredUserNumber = SquareNumber(userNumber);

DisplayResult(userName, squaredUserNumber);





    }
}