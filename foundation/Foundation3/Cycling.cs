public class Cycling : Activity
{
    // VARIABLES
    private double _speed; //in X miles per hour

    // CONSTRUCTORS
    public Cycling(string date, int duration, int speed) : base(date, duration)
    {
        _speed = speed;
        // Console.WriteLine($"Cycling Speed: {_speed}");//TESTING
    }

    // METHODS
    public override string GetSummary()
    {
        int duration = Duration();
        string date = Date();
        //    6      =   12   / 60 *    30
        double distance = _speed / 60 * duration; // CALCULATION PROBLEM WHY???
        double pace = 60 / _speed;
        
        // Console.WriteLine($"Cycling Duration: {duration}");//TESTING
        // Console.WriteLine($"Cycling Distance: {distance}");//TESTING
        // Console.WriteLine($"Cycling Speed: {_speed}");//TESTING
        // Console.WriteLine($"Cycling Pace: {pace}");//TESTING
        // Console.WriteLine($"Cycling Date: {date}");//TESTING

        string activitySummary = $"{date} Cycling ({duration} min.) - Distance: {distance:N2} miles, Speed: {_speed:N2} mph, Pace: {pace:N2} minutes per mile";
        return activitySummary;
    }
}