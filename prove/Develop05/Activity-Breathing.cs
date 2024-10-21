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

        int round = 1;

        while (currentTime <= futureTime)
        {
            
            //     Print a series of alternating messages such as "breathe in" and "breathe out"
            // Countdown(9);//     (Call Countdown Method)
            //     Continue looping the alternating messages until the user-set duration has expired.
            
            // int countdown = 5;
            

            // while (countdown > 0)
            if (round == 1)
            {
                Console.Write("Breathe in...");
                round = 2;
                Countdown(5);
            }
            else if (round == 2)
            {
                Console.Write("Breathe out...");
                round = 1;
                Countdown(5);
            }
            Console.WriteLine();
            Console.WriteLine();
            // countdown --;

            // Console.WriteLine(countdown);
                // Thread.Sleep(1000);//How long it actually pauses between frames, in milliseconds
            // Console.Write("\b \b"); // Erase the previous character
            // Console.WriteLine("countdown");

            // Console.Write("Breathe out...");

            // Thread.Sleep(1000);

            currentTime = DateTime.Now;
        }

        
        EndingMessage();//     Print Ending Message (from Activity Class)
    }





}







