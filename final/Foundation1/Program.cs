using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store the videos in.
        List<Video> videos = new();

        // Create the videos and add them to a list.
        Video CarVideo = new("Car video", "M8erV8", 120);
        CarVideo.AddComment(new Comments("Fred", "Great video!"));
        CarVideo.AddComment(new Comments("Jerry", "I love cars!"));
        CarVideo.AddComment(new Comments("Jerry", "Vrrooom!!! Did y'all hear them engines???"));
        videos.Add(CarVideo);

        Video SushiPrep = new("SushiPrep","Suh1S@mura1",1567);
        SushiPrep.AddComment(new Comments("Joe Hisaishi", "This is very helpful, thanks!"));
        SushiPrep.AddComment(new Comments("Robert Kiyosaki", "What a great business idea!"));
        SushiPrep.AddComment(new Comments("KikkoMan", "I love sushi!"));
        videos.Add(SushiPrep);

        Video CatReel = new("CatReel","NeonC@t",10);
        CatReel.AddComment(new Comments("MeowMix", "Cats are the best!"));
        CatReel.AddComment(new Comments("Cat Stevens", "This made my day!"));
        CatReel.AddComment(new Comments("Caterina", "I am a cat."));
        videos.Add(CatReel);

        // Display the information for each video.
        foreach (var video in videos)
        {
            Console.WriteLine(video.GetVideoDetails());
            Console.WriteLine($"Number of comments: {video.GetCommentNumber()}");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine(comment.GetCommentDetails());
            }
            Console.WriteLine();
        }
    }
}