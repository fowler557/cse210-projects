using System;

class Program
{
    static void Main(string[] args)

    {
        int userInput = 0;

        while(userInput != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflection activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");

            userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 14);
                    breathingActivity.BreathInBreathOut();
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                default:
                    Console.WriteLine("Please enter a number");
                    break;

                
        
            }
        }
    }
}