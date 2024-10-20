
using System.Runtime.CompilerServices;

public class Activity()
{

    protected string _activityName = "";
    protected string _activityDescription = "";
    protected int _activityDuration = 0;

    protected void StartingMessage()
    {
        string inputTime = "";
        Console.Clear();
        Console.WriteLine(_activityName);
        Console.WriteLine(_activityDescription);
        Console.WriteLine("How long would you like to do this activity? (in seconds)");
        inputTime = Console.ReadLine();
        if (int.TryParse(inputTime, out _activityDuration))
        {
            // Console.WriteLine($"VALUE CONVERTED: {_activityDuration}");//For testing purposes.
        }
        else
        {
            Console.WriteLine("That is not an acceptable value. Value set to 0 seconds.");
            _activityDuration = 0;
        }

        Console.WriteLine("Prepare for the activity to begin.");
        Pause();

    }

    protected void SetActivityDetails(string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
    }

    protected void Pause()
    {
        int pauseDuration = 5; //This duration is in seconds
        int pausePeriod = 250;//This duration is in milliseconds, which is how the computer counts time.

        // prints an animation of some sort for a set duration to indicate waiting time. ie: the user can see the program is running.

        // RUN PAUSE ANIMATION!!!
        while (pauseDuration != 0)
        {
            
            
            Console.WriteLine("/");
            Thread.Sleep(pausePeriod);//How long it actually pauses between frames, in milliseconds
            Console.Write("\b \b"); // Erase the previous character

            Console.WriteLine("-");
            Thread.Sleep(pausePeriod);
            Console.Write("\b \b"); // Erase the previous character

            Console.WriteLine("/");
            Thread.Sleep(pausePeriod);
            Console.Write("\b \b"); // Erase the previous character

            Console.WriteLine("-");
            Thread.Sleep(pausePeriod);
            Console.Write("\b \b"); // Erase the previous character

            pauseDuration -= 1;

        }

    }

    protected void Countdown()
    {
        int countDuration = 10; //This duration is in seconds
        // int countPeriod = 1000;//This duration is in milliseconds, which is how the computer counts time. This would be redundant, since it can be defaulted to 1000 milliseconds for a reliable 1 second
        
        while (countDuration != 0)
        {
            Console.Clear();
            Console.WriteLine(countDuration);
            Thread.Sleep(1000);
            countDuration --; //Reduces Countdown by 1
        }
    }

    protected void EndingMessage()
    {
        Console.Clear();
        Console.WriteLine("Congratulations, you did a great job!");
        Pause();
        Console.WriteLine($"You finished the {_activityName} after {_activityDuration} seconds.");
        Pause();

        // Loop ends, returns to Menu
    }

}
/*
variable: Activity Name (set to blank, or other default)
variable: Activity description (set to blank or other default)
variable: Time duration (set to 0 by default)



Method: Starting Message
    Prints:
        Activity Name (from subclass)
        Description of the Activity (from subclass)
        Asks for (Then sets) the duration of the activity (in seconds)
            USER INTERFACE: GET DURATION
            Set variable: Time Duration
        Tells the user to prepare
    call the Pause Method

Method: Pause
    Prints an animation of some sort for a set duration to indicate waiting time

Method: countdown
    Prints a countdown sequence each second for X seconds (used for Breathing and Listing activities)

Method: Ending Message
    Prints:
        Common Ending message telling the user
            they did a good job
    Calls the Pause Method
    Prints:
        The activity they completed (from subclass)
        The length of time of the activity
    Calls the Pause Method
    Finishes the activity cycle (return to menu)
*/