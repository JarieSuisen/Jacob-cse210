public class ListingActivity : Activity
{
        
    private string activityName = "Listing Activity";
    private string activityDetails = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    
    private List<string> promptList = new List<string>();
    private List<string> inputList = new List<string>();

    public void setDetails()
        {
            SetActivityDetails(activityName, activityDetails);
        }

    public void ListingTime()
    {
        StartingMessage();//     Prints Start Message (From Activity Class); Prints Description (From Activity Class, using the variable in Breathing Activity)
        
        // LISTING PROGRAM STARTS

        Random randomGenerator = new Random();//Generate randoms
        int promptNumber = randomGenerator.Next(0, promptList.Count());//Grab a random number from possible item count in list
        string prompt = promptList[promptNumber];//assign the data at that position in the list for use
        Console.WriteLine(prompt);//Print the prompt


        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_activityDuration);
        DateTime currentTime = DateTime.Now;
        
        while (currentTime != futureTime)
        {


            //     Print:
                //     Random Prompt (from Starting message list)
                //     (Loop sequence)
                //         (Call Countdown Method)
                //         Print: Prompt user to keep listing items
            inputList.Add(Console.ReadLine());
            Console.WriteLine("What else comes to mind?");
                
        }
        // (when activity duration ends):
        //     Print: Count of items User entered
        int inputCount = inputList.Count();
        Console.WriteLine($"You listed {inputCount} items!");
        

        EndingMessage();//     Print Ending Message (from Activity Class)
    }







//     Variable (int): Number of items User enters
//     List (string): Starting Message List

//     Method(setter): Set Activity Name to "Listing Activity" (or whatever)
//     Method(setter): Set Activity Description to "(whatever)

    // Method
    
    //     Print Ending Message (from activity Class)

}