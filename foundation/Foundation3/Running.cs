public class Running : Activity
{
    // VARIABLES
    private int _distance; //in X miles

    // CONSTRUCTORS
    public Running(string date, int duration, int distance) : base(date, duration)
    {
        _distance = distance;

        // Console.WriteLine($"Running Distance: {_distance}");//TESTING
    }

    // METHODS
    public override string GetSummary()
    {
        int duration = Duration();
        string date = Date();
        //    12  =     6     /     30   * 60
        int speed = _distance / duration * 60; // CALCULATION PROBLEM WHY???
        int pace = duration / _distance;

        Console.WriteLine($"Running Duration: {duration}");//TESTING
        Console.WriteLine($"Running Distance: {_distance}");//TESTING
        Console.WriteLine($"Running Speed: {speed}");//TESTING
        Console.WriteLine($"Running Pace: {pace}");//TESTING
        // Console.WriteLine($"Running Date: {date}");//TESTING

        string activitySummary = $"{date} Running ({duration} min.) - Distance: {_distance} miles, Speed: {speed} mph, Pace: {pace} minutes per mile";
        return activitySummary;
    }
}
