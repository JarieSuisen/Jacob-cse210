public class BreathingActivity : Activity
{

    private string activityName = "Breathing Activity";
    private string activityDetails = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    
    public void setDetails()
        {
            SetActivityDetails(activityName, activityDetails);
        }

    public void BreathingTime()
    {
        StartingMessage();//     Prints Start Message (From Activity Class); Prints Description (From Activity Class, using the variable in Breathing Activity)
        
        // BREATHING PROGRAM STARTS
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_activityDuration);
        DateTime currentTime = DateTime.Now;

        while (currentTime <= futureTime)
        {
            //     Print a series of alternating messages such as "breathe in" and "breathe out"
            Countdown();//     (Call Countdown Method)
            //     Continue looping the alternating messages until the user-set duration has expired.

            Console.Write("Breathe in...");
            Console.WriteLine("5");
            Thread.Sleep(1000);//How long it actually pauses between frames, in milliseconds
            Console.Write("\b \b"); // Erase the previous character
            Console.WriteLine("4");

            Console.Write("Breathe out...");

            Thread.Sleep(1000);

            currentTime = DateTime.Now;
        }

        
        EndingMessage();//     Print Ending Message (from Activity Class)
    }





}







