public class Video
{


    private string _title = "";

    private string _author = "";

    private int _length = 0;

    private List<Comments> comments = new List<Comments>();


    public void AddVideo
    (
        // List of inputs
        string title,
        string author,
        int length,
        string comment1,
        string username1,
        string comment2,
        string username2,
        string comment3,
        string username3
    )

    {
        // Generate the content of the video.
        _title = title;
        _author = author;
        _length = length;
        Comments commentPair1 = new Comments();
        commentPair1.AddComment(comment1, username1);
        comments.Add(commentPair1);

        Comments commentPair2 = new Comments();
        commentPair2.AddComment(comment2, username2);
        comments.Add(commentPair2);

        Comments commentPair3 = new Comments();
        commentPair3.AddComment(comment3, username3);
        comments.Add(commentPair3);



        // Console.WriteLine($"TESTING: The added video is {_title} by {_author} and is {_length} seconds long.");

    }


    public void ReadVideo()
    {


        // Generate the video details
        string videoDetails = $"{_title} by {_author}, {_length} seconds long.\n";
        
        // Print the video details
        Console.WriteLine(videoDetails);

        // get and generate the comments for the video
        foreach (Comments comment in comments)
        {
            comment.ReadComment();
        }
        



        // return videoDetails;
    }






}