using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C# in 10 Minutes", "Code Academy", 600);
        video1.AddComment(new Comment("Alice", "Very helpful!"));
        video1.AddComment(new Comment("Bob", "Clear explanation."));
        video1.AddComment(new Comment("Charlie", "Loved this tutorial."));
        videos.Add(video1);

        Video video2 = new Video("OOP Concepts Explained", "Tech World", 900);
        video2.AddComment(new Comment("Diana", "Encapsulation finally makes sense."));
        video2.AddComment(new Comment("Eric", "Great examples."));
        video2.AddComment(new Comment("Fiona", "Please make more videos."));
        videos.Add(video2);

        Video video3 = new Video("Abstraction in C#", "Dev Simplified", 750);
        video3.AddComment(new Comment("George", "Straight to the point."));
        video3.AddComment(new Comment("Helen", "Nice breakdown."));
        video3.AddComment(new Comment("Ian", "Saved me for my exam."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetAuthor());
            Console.WriteLine("Length (seconds): " + video.GetLength());
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(comment.GetCommenterName() + ": " + comment.GetCommentText());
            }

            Console.WriteLine();
        }
    }
}
