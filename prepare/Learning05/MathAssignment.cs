public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";

    public MathAssignment()
    {
        _textbookSection = "Section Not Set";
        _problems = "No problems detailed";
    }

    public void SetMathAssignment(string name, string topic, string textbookSection, string problems)
    {
        _textbookSection = textbookSection;
        _problems = problems;
        SetAssignment(name, topic);
    }

    public string GetHomeworkList()
    {
        return $"{GetSummary()}, {_textbookSection}: {_problems}";
    }
}