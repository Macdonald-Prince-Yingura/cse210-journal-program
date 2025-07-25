using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video v1 = new Video("How to Cook Jollof Rice", "Chef Kwame", 420);
        v1.AddComment(new Comment("Ama", "This recipe is amazing!"));
        v1.AddComment(new Comment("Kojo", "I tried it and loved it."));
        v1.AddComment(new Comment("Yaa", "Simple and clear instructions."));
        videos.Add(v1);

        // Video 2
        Video v2 = new Video("Basics of C# Programming", "Dev School", 960);
        v2.AddComment(new Comment("John", "Very helpful tutorial!"));
        v2.AddComment(new Comment("Sarah", "Well explained."));
        v2.AddComment(new Comment("Liam", "Perfect for beginners."));
        videos.Add(v2);

        // Video 3
        Video v3 = new Video("DIY Solar Power System", "Green Energy Hub", 780);
        v3.AddComment(new Comment("Kwesi", "This will help me a lot in my village."));
        v3.AddComment(new Comment("Linda", "Great breakdown of the steps."));
        v3.AddComment(new Comment("Zara", "Can you do one for bigger systems?"));
        videos.Add(v3);

        // Display each video and its comments
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
