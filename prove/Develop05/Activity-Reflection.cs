public class ReflectionActivity : Activity
{
    
    private string activityName = "Reflection Activity";
    private string activityDetails = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    private int reflectionCount = 0;
    
    private List<string> promptList = new List<string>();
    private List<string> questionList = new List<string>();
    

    public void setDetails()
        {
            SetActivityDetails(activityName, activityDetails);
        }

    public void ReflectionTime()
    {
        StartingMessage();//     Prints Start Message (From Activity Class); Prints Description (From Activity Class, using the variable in Breathing Activity)
        
        // REFLECTION PROGRAM STARTS

        //     Print: one Random Prompt (from prompt list)
        Random randomGenerator = new Random();//Generate randoms
        int promptNumber = randomGenerator.Next(0, promptList.Count());//Grab a random number from possible item count in list
        string prompt = promptList[promptNumber];//assign the data at that position in the list for use
        Console.WriteLine(prompt);//Print the prompt

                
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_activityDuration);
        DateTime currentTime = DateTime.Now;
        
        while (currentTime != futureTime)
        {
        
            //         start loop:
            //             random (or in order) Question (from Question list; maybe avoid duplicates)
            //                  user enters in things, hits enter.

            // Random randomGenerator = new Random();//Generate randoms
            int questionNumber = randomGenerator.Next(0, questionList.Count());//Grab a random number from possible item count in list
            string question = questionList[questionNumber];//assign the data at that position in the list for use
            Console.WriteLine(question);//Print the prompt

            
                // Count goes up, tracking how many 
            Pause();//             Call Pause Method
            //             (Repeat random questions and pauses for the Set Duration of activity)

        }
        EndingMessage();//     Print Ending Message (from Activity Class)
    }





// List(string): Prompt List
// list(string): Question list

// Method(setter): Set Activity Name to "Reflection Activity" (or whatever)
// Method(setter): Set Activity Description to "(whatever)

// Method:
//     Print:
//         one Random Prompt (from prompt list)
//         start loop:
//             random (or in order) Question (from Question list; maybe avoid duplicates)
//             Call Pause Method
//             (Repeat random questions and pauses for the Set Duration of activity)
//     Print Ending Message (from activity class)
}