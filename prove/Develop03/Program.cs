using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string userVerseReferenceBook = "";
        string userVerseReferenceChapter = "";
        string userVerseReferenceVerse = "";
        string userVerseReferenceEndVerse = "";
        string userVerseWords = "";

        Console.WriteLine("Welcome to the Scripture Memorizer program!");
        Console.WriteLine("Please follow the instructions to memorize your scripture.");
        Console.Write("Enter the book name: ");
        userVerseReferenceBook = Console.ReadLine();
        Console.Write("Enter the chapter number: ");
        userVerseReferenceChapter = Console.ReadLine();
        Console.Write("Enter the verse number: ");
        userVerseReferenceVerse = Console.ReadLine();
        Console.Write("Enter the end verse number or 0 if there is only one verse: ");
        userVerseReferenceEndVerse = Console.ReadLine();
        Console.Write("Enter the verse text: ");
        userVerseWords = Console.ReadLine();

        Reference reference = new Reference($"{userVerseReferenceBook}", $"{userVerseReferenceChapter}", $"{userVerseReferenceVerse}", $"{userVerseReferenceEndVerse}");
        List<Word> words = new List<Word>();

        string versesWords = $"{userVerseWords}";
        string[] wordsArray = versesWords.Split(" ");

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
    // static void Main(string[] args)
    // {
        
    //     Reference reference = new Reference("Proverbs", "3", "5", "6");
    //     List<Word> words = new List<Word>();

    //     string verses = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";
    //     string[] wordsArray = verses.Split(" ");

    //     foreach (string word in wordsArray)
    //     {
    //         words.Add(new Word(word));
    //     }

    //     Scripture scripture = new Scripture(reference, words);

    //     while (!scripture.AllWordsHidden())
    //     {
    //         Console.Clear();
    //         scripture.DisplayScripture();
    //         Console.WriteLine("\nPress Enter to hide a word, or type 'quit' to exit: ");
    //         var userInput = Console.ReadLine();
    //         if (userInput.ToLower() == "quit")
    //             break;
    //         else
    //             scripture.HideRandomWords(3);
    //     }

    //     Console.Clear();
    //     scripture.DisplayScripture();
    //     Console.WriteLine("\nProgram ended.");
    // }
}