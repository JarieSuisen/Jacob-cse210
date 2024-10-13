using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");
        Console.Clear();

        List<Video> videos = new List<Video>();

        Video video1 = new Video();
        video1.AddVideo(
            "Dance-off, What a Wonderful Life", "John Carpenter", 15895, "What is this about?", "@CarlosTheFighter", "I wish I had a style like that", "@WeakBodyAdult", "SPAM SPAM SPAM", "@SirSpamalot"
        );
        videos.Add(video1);

        Video video2 = new Video();
        video2.AddVideo(
            "The TRUTH about tasty chicken", "Farmer Bob", 1456225, "I just want to eat chicken...", "@WinnerWinnerChickenDinner", "I TOLD YOU TO DODGE!!!", "@MrPiccolo", "I thought this was more propoganda... instead, I'm hungry. Thanks.", "@NeverFullNoMatterHowMuchIEatPleaseSendHelp"
        );
        videos.Add(video2);

        Video video3 = new Video();
        video3.AddVideo(
            "I Get a Passing Grade For This Video, Right?", "Wishful Student", 999966645, "way too long, who thought this much empty screen time was a good idea? Fail them.", "@JudgementalJerk", "I think the video is broken dude.", "@TechSavvy136354", "EVEN MORE SPAM, WAHAHAHA!", "@SirSpamalotThe2nd"
        );
        videos.Add(video3);



        foreach (Video video in videos)
        {
            Console.WriteLine("");
            Console.WriteLine("Video and comments:");
            Console.WriteLine("");

            video.ReadVideo();

        }

        Console.WriteLine("");


    }
}