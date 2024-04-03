using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create an example of each event type
        Lecture lecture = new Lecture("RF systems inovation conference", "Explore the latest in RF technology.", new DateTime(2024, 4, 15, 18, 0, 0), new Address("576 Borusha St", "Westville", "TN", "76864"), "Justin Sporus", 115);
        Reception reception = new Reception("Annual Charity Ball", "A night of elegance for a good cause.", new DateTime(2024, 5, 20, 19, 0, 0), new Address("456 Home Rd", "Bowash City", "IN", "67890"), "rsvp@charityball.org");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Summer Music Festival", "Enjoy music under the stars.", new DateTime(2024, 7, 4, 17, 0, 0), new Address("789 Grass Ave", "Hope Town", "FL", "10112"), "Sunny with a chance of light showers");

        // Display marketing messages for each event
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
} 