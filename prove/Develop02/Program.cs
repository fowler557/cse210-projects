using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int userChoice = 1;

        Console.WriteLine("Welcome to the Journal program");

        while(userChoice != 5)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write ");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Load ");
            Console.WriteLine("4. Save ");
            Console.WriteLine("5. Quit ");

            userChoice = int.Parse(Console.ReadLine());
            
            switch (userChoice)
            {
                case 1:
                    PromptGenerator promptGenerator = new PromptGenerator();
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.Write($"\n{prompt}\n> ");
                    string response = Console.ReadLine();


                    //Entry 
                    Entry entry = new Entry();
                    entry._prompt = prompt;
                    entry._response = response;
                    entry._entryDate = DateTime.Now;
                
                    //Journal
                    journal._entries.Add(entry);
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    journal.LoadEntries();
                    break;
                case 4:
                    journal.SaveEntries();
                    break;
                case 5:
                    Console.WriteLine("Goodbye! Thanks for using the Journal program!");
                    break;
                default:
                    Console.WriteLine("Please enter a number");
                    break;
            }
        
        }

    }
}