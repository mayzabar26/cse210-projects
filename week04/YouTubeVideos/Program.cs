using System;

class Program
{
    static void Main(string[] args)
    {
        //Create a list of video
        List<Video> videos = new List<Video>();

        //Create videos
        Video video1 = new Video("Baking with Cheryl", "Cheryl Recipes", 600);
        Video video2 = new Video("The Strangers: Chapter 1", "Is Tamara Here", 720);
        Video video3 = new Video("Going to New York for 2 days", "Madelaine Petsch", 540);

        //Create and add comments to the video1
        video1.AddComment(new Comment("Ana", "It's delicious!"));
        video1.AddComment(new Comment("Marjorie", "Can I use chocolate instead of strawberry?"));
        video1.AddComment(new Comment("Betty", "I need to try this recipe."));

        //Create and add comments to the video2
        video2.AddComment(new Comment("Marjorie", "The movie is fantastic. Can't wait to watch chapter 2."));
        video2.AddComment(new Comment("Chad", "The Strangers is my favorite horror movie."));
        video2.AddComment(new Comment("Alex", "3 movies shot in 52 days? That's crazy!!"));

        //Create and add comments to the video3
        video3.AddComment(new Comment("Veronica", "New York is so beautiful."));
        video3.AddComment(new Comment("Marissa", "Any vegan restaurant tips?"));
        video3.AddComment(new Comment("Maya", "Did you watch any Broadway show?"));

        //Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        //Display video's info
        foreach(Video video in videos)
        {
            video.DisplayInfo();
        }
        
    }
}