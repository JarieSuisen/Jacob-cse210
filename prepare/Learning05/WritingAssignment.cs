public class WritingAssignment : Assignment
{

    private string _title = "";

    public WritingAssignment()
    {
        _title = "No Title";
    }

    public void SetWritingAssignment(string name, string topic, string title)
    {
        _title = title;
        SetAssignment(name, topic);
    }


    public string GetWritingInformation()
    {
        return $"{GetSummary()}, {_title}";
    }

}