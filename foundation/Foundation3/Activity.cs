public abstract class Activity
{
    // VARIABLES
    private string _date; // Date of the activity, Format: "DD MMM YYYY"
    private int _duration; // Length of the activity, in Minutes

    // CONSTRUCTORS
    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
        // _activityName = activityName;
    }

    // METHODS
    public string Date()
    {
        return _date;
    }
    public int Duration()
    {
        return _duration;
    }
    public abstract string GetSummary();
    /*
    Customize how to get for each subclass. BUT each shares the following format:
    string activitySummary = $"{_date} {_activityName} ({_duration}) - Distance: {_distance} miles, Speed: {_speed} mph, Pace: {_pace} minutes per mile"
    
    If a detail is not tracked by that class, it must be calculated!

    */
}