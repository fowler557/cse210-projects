using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Reference reference = new Reference("Proverbs", "3", "5", "6");
        List<Word> words = new List<Word>();

        string verses = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";
        string[] wordsArray = verses.Split(" ");

        foreach (string word in wordsArray)
        {
            words.Add(new Word(word));
        }

        Scripture scripture = new Scripture(reference, words);

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            scripture.DisplayScripture();
            Console.WriteLine("\nPress Enter to hide a word, or type 'quit' to exit: ");
            var userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
                break;
            else
                scripture.HideRandomWords(3);
        }

        Console.Clear();
        scripture.DisplayScripture();
        Console.WriteLine("\nProgram ended.");
    }
}