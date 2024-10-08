using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");

        // CLEAR THE CONSOLE
        Console.Clear();
        string userReply = "";


        // GENERATE THE SCRIPTURE
        Scripture scripture = new Scripture();

        // Set the Scripture Text
        scripture.SetScriptureText
        (
            "Happy is the man that findeth wisdom, and the man that getteth understanding. For the merchandise of it is better than the merchandise of silver, and the gain thereof than fine gold."
        );
        
        // SET THE SCRIPTURE REFERENCE
        scripture.SetScriptureReference
        (
            /*Book*/"Proverbs", 
            /*Chapter*/ 3, 
            /*Verse*/ 13, 
            /*Ending Verse*/ 14
        );

        // NUMBER OF WORDS TO HIDE:
        int hideThisManyWords = 2;



        // CLEAR THE CONSOLE
        Console.Clear();

        // SHOW INITIAL OUTPUT
        scripture.GetDisplayText();

        // 
        while (userReply != "quit")
        {
            Console.WriteLine("");
            // PROMPT TO CONTINUE OR END PROGRAM
            Console.WriteLine("Press ENTER to continue or type 'quit' to end the program.");
            userReply = Console.ReadLine().ToLower();

            // CLEAR THE CONSOLE
            Console.Clear();

            // RANDOMLY REMOVE SOME WORDS
            scripture.HideRandomWords(hideThisManyWords);

            // GET THE NEW TEXT TO SHOW
            scripture.GetDisplayText();
            












            
            // CHECKS IF SCRIPTURE IS FULLY HIDDEN AND SHOULD END THE PROGRAM
            bool closeCheck = scripture.IsCompletelyHidden();
            if (closeCheck == true)
            {
                userReply = "quit";
            }





        }





    }
}