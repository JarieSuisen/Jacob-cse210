public class EternalGoal : Goal
{
    
    // CONSTRUCTORS
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }

    // METHODS
    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");

        return _points;
        // UPDATE POINTS???
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        string outputString = $"EternalGoal:{_name},{_shortDescription},{_points}";
        return outputString;
    }

}