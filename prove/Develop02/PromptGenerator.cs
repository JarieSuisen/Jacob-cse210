using System.Security.Cryptography.X509Certificates;

public class PromptGenerator
    {

        public string _newPrompt = "";


        public string RandomPrompt()
            {
                List<string> prompts = new List<string>();
                prompts.Add("Who was the most interesting person I interacted with today?");
                prompts.Add("What was the best part of my day?");
                prompts.Add("How did I see the hand of the Lord in my life today?");
                prompts.Add("What was the strongest emotion I felt today?");
                prompts.Add("If I had one thing I could do over today, what would it be?");
                prompts.Add("What kind of weather did I enjoy today?");

                // int x = prompts.Count();

                Random randomGenerator = new Random();
                int number = randomGenerator.Next(0, prompts.Count());

                string promptText = prompts[number];

                Console.WriteLine(promptText);

                return promptText;
            }
    }