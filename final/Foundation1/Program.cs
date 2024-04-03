using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating video instances
        Video video1 = new Video("How to do Laplace Transforms", "Math Guy", 12);
        video1.AddComment(new Comment("John Bridger", "Great video, thanks for the explanation!"));
        video1.AddComment(new Comment("Jane Smith", "This really helped me understand intuitively what Laplace transforms are!! "));
        video1.AddComment(new Comment("Bob Johnson", "Thanks! Can you make a video on the Fourier transform?"));

        Video video2 = new Video("All four Grindavik Eruption beginnings", "Live From Iceland", 7);
        video2.AddComment(new Comment("Alice Brown", "So beautiful!!! Why can't we get more cameras to other volcanoes!"));
        video2.AddComment(new Comment("Chris Green", "It's a shame those houses had to burn..."));
        video2.AddComment(new Comment("Diana Adams", "Did you guys see the mini tornado at around minute 3?"));

        Video video3 = new Video("EF-4 tornado sound", "Pecos Hank", 5);
        video3.AddComment(new Comment("Brian Furgison", "Best footage of that classic tornado roar! Thanks for all you do Pecos:)"));
        video3.AddComment(new Comment("Sam Adamson", "I'm so jealous! I used to live 14 miles from there!"));
        video3.AddComment(new Comment("Ricky Jessee", "Next time you could make a video on your film equipment? Seriously, great job!"));
        video3.AddComment(new Comment("Steve Smith", "Pecos uploads a video! WooooooooHooooooooo!"));
        // Adding video objects to the video list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Displaying videos and their comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}, Author: {video.GetAuthor()}, Length: {video.GetLenth()} minutes");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }
            Console.WriteLine(); // Adding a line break for readability
        }
    }
}