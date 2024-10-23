// For my creativity portion of this project I added likes and views.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to Cook Pasta", "Chef John", 300);
        video1.AddComment("Alice", "This recipe is amazing!");
        video1.AddComment("Bob", "I tried it, and it worked perfectly.");
        video1.AddComment("Charlie", "Thanks for the tips!");

        Video video2 = new Video("Travel Vlog - Paris", "Traveler Tom", 600);
        video2.AddComment("Diana", "Beautiful shots!");
        video2.AddComment("Eve", "I want to visit Paris too.");
        video2.AddComment("Frank", "Great video, Tom!");

        Video video3 = new Video("Learn C# Basics", "Code Academy", 900);
        video3.AddComment("George", "This tutorial is very helpful.");
        video3.AddComment("Hannah", "Thanks for making this easy to follow.");
        video3.AddComment("Ivan", "Great content, keep it up!");

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}

