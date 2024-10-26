using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class GoalManager
{
    // VARIABLES
    private List<Goal> _goals;
    public int _score;

    
    // CONSTRUCTORS
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }


    // METHODS

    public void Start() // - This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
    {
        string userInput = "0";

        Console.WriteLine("Welcome to EternalGoal");
        Console.WriteLine();
        
        
        while (userInput != "6")
        {
            // Console.Clear();
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine();
            Console.WriteLine();
            if (userInput == "1")
            {
                CreateGoal();
            }

            else if (userInput == "2")
            {
                ListGoalDetails();
            }

            else if (userInput == "3")
            {
                SaveGoals();
            }

            else if (userInput == "4")
            {
                LoadGoals();
            }

            else if (userInput == "5")
            {
                RecordEvent();
            }

            else if (userInput == "6")
            {
                Console.WriteLine("Goodbye");
            }

            else
            {
                Console.WriteLine("That is not a valid option.\nPlease select a choice from the menu.");
            }


        }
        

    }
    public void DisplayPlayerInfo() // - Displays the players current score.
    {
        Console.WriteLine($"You have {_score} points.");
    }
    public void ListGoalNames() // - Lists the names of each of the goals.
    {
        int goalCount = 0;
        foreach (Goal goal in _goals)
        {
            goalCount ++;

            string goalString = goal.GetDetailsString("name");
            string baseString = $"{goalCount}. {goalString}";

            Console.WriteLine(baseString);
        }
    }
    public void ListGoalDetails() // - Lists the details of each goal (including the checkbox of whether it is complete).
    {
        int goalCount = 0;
        foreach (Goal goal in _goals)
        {
            goalCount ++;

            string goalString = goal.GetDetailsString("details");
            string baseString = $"{goalCount}. {goalString}";

            Console.WriteLine(baseString);
        }
    }
    public void CreateGoal() // - Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
    {
        // Console.Clear();
        Console.WriteLine("Which type of goal would you like to make?");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        string userInput = Console.ReadLine();
        Console.WriteLine();


        Console.Write("What is the name of this goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of this goal? ");
        string description = Console.ReadLine();
        Console.Write("How many points are associated with this goal?");
        int points = int.Parse(Console.ReadLine());
        
        if (userInput == "1")
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }
        else if (userInput == "2")
        {
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }
        else if (userInput == "3")
        {
            Console.Write("How many times does this goal need accomplished to earn a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("How many bonus points are earned for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }
        else
        {
            Console.WriteLine("Returning to main menu...");
        }
        // Console.Clear();
}
    public void RecordEvent() // - Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
    {
        Console.WriteLine("Your goals are:");
        ListGoalNames();
        Console.Write("Which goal have you completed? (Enter the number of the goal from the list.) ");
        int goalUpdate = int.Parse(Console.ReadLine());
        goalUpdate --;//This adjusts for the fact that Lists start at ZERO, not ONE as is listed for the user's convenience.
        
        // _goals[goalUpdate].RecordEvent();
        _score += _goals[goalUpdate].RecordEvent();

        

        Console.WriteLine($"Your total points are now {_score} points!");
    }
    public void SaveGoals() // - Saves the list of goals to a file.
    {




        // LOAD CUSTOM SAVE FILE
        Console.WriteLine("Enter the name you would like to save your progress as:");
        string fileName = Console.ReadLine();


        // string fileName = "GoalsRecord";

        using (StreamWriter outputFile = new StreamWriter($"{fileName}.txt"))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
                outputFile.WriteLine(goal.GetStringRepresentation());
        }







    }
    public void LoadGoals() // - Loads the list of goals from a file.
    {
 
        // LOAD CUSTOM SAVE FILE
        Console.WriteLine("Enter the name of the file you wish to load:");
        string fileName = Console.ReadLine();

        // LOAD TESTING SAVE FILE

        _goals = new List<Goal>();
        
        // string fileName = "GoalsRecord";

        string[] lines = System.IO.File.ReadAllLines($"{fileName}.txt");
        
        
        _score = int.Parse(lines[0]);
        // string text = lines[];
        
        foreach (string line in lines)//ADJUST THESE DETAILS TO ACTUALLY WORK WITH THE PROGRAM!!!
        {
            if (line == lines[0])
            {
                // line.Skip(1);}



            // var isNumeric = int.TryParse(line);
            // if (isNumeric == true)
            // if (line != line[0])
            // {
            _score = int.Parse(line);
            //     // Console.WriteLine(line);//TESTING
            }
        
            else
            {
                // Console.WriteLine(line);//TESTING
                string[] parts = line.Split(":");
                // Console.WriteLine(parts);//TESTING
                string type = parts[0];
                // Console.WriteLine(type);//TESTING
                string details = parts[1];
                // Console.WriteLine(details);//TESTING

                string[] detailsParts = details.Split(",");
                string name = detailsParts[0];
                string description = detailsParts[1];
                int points = int.Parse(detailsParts[2]);
                if (type == "SimpleGoal")
                {
                    bool isComplete = bool.Parse(detailsParts[3]);
                    // string isCompleteString = detailsParts[3];
                    // if (isCompleteString == "true")
                    // {
                    //     bool isComplete = true;
                    // }
                    // else
                    // {
                    //     bool isComplete = false;
                    // }

                    
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points, isComplete);
                    _goals.Add(simpleGoal);
                }
                else if (type == "EternalGoal")
                {
                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    _goals.Add(eternalGoal);
                }
                else if (type == "ChecklistGoal")
                {
                    int target = int.Parse(detailsParts[3]);
                    int bonus = int.Parse(detailsParts[4]);

                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                    _goals.Add(checklistGoal);
                }
            }    

        }



    }

    public void IncreaseScore(int points)
    {
        _score += points;
    }

}