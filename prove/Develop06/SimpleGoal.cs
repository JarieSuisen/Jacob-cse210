public class SimpleGoal : Goal
{
    // VARIABLES
    private bool _isComplete;
    
    // CONSTRUCTORS
    public SimpleGoal(string name, string description, int points, bool optionalIsComplete = false) : base(name, description, points)
    {
        if (optionalIsComplete == false)
        {
            _isComplete = false;
        }
        else if (optionalIsComplete == true)
        {
            _isComplete = true;
        }
    }

    // METHODS
    public override int RecordEvent()
    {
        if (_isComplete == false)
        {
            _isComplete = true;

            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            // int points = _points;
            
            return _points;

        }
        else
        {
            Console.WriteLine("You have already completed this goal. Returning to main menu.");
            return 0;
        }
        
        

        

    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string outputString = $"SimpleGoal:{_name},{_shortDescription},{_points},{_isComplete}";
        return outputString;
    }


}