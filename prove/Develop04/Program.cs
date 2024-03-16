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
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 10);
                    breathingActivity.DisplayStartMessage();
                    breathingActivity.BreathInBreathOut();
                    breathingActivity.DisplayEndMessage();
                    break;

                case 2:
                    ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 10);
                    reflectingActivity.DisplayStartMessage();
                    reflectingActivity.DisplayReflectingPrompt();
                    reflectingActivity.DisplayQuestionPrompt();
                    reflectingActivity.DisplayEndMessage();
                    break;

                case 3:
                    ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 10);
                    listingActivity.DisplayStartMessage();
                    listingActivity.DisplayListingPrompt();
                    listingActivity.UserList();
                    listingActivity.DisplayEndMessage();
                    break;

                case 4:
                    Console.Clear();
                    break;

                default:
                    Console.WriteLine("Please enter a number");
                    break;

                
        
            }
        }
    }
}