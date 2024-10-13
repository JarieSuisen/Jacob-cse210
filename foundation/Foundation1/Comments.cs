public class Comments
{


    private string _comment = "";

    private string _username = "";


    public void AddComment(string comment, string username)
    {

        _comment = comment;

        _username = username;

    }

    public void ReadComment()
    {

        string commentData = $"{_username}: {_comment}";

        Console.WriteLine(commentData);

    }

    
}