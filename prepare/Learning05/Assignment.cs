public class Assignment
{


    private string _studentName = "";
    private string _topic = "";

    public Assignment()
    {
        _studentName = "Anonymous Student";
        _topic = "No Topic Selected";
    }

    public void SetAssignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {

        return $"{_studentName}: {_topic}";

    }

}