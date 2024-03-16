using System;

class Program
{
    static void Main(string[] args)

    {
        int userInput = 0;

        while(userInput != 6)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Record Event");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");

            userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

                case 6:
                    break;

                default:
                    Console.WriteLine("Please enter a number");
                    break;

                
        
            }
        }
    }
}