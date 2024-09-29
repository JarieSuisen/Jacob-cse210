using System;
using System.Runtime.CompilerServices;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        /*BLANK LINE*/Console.WriteLine("");
        
        int userSelection = 0;
        

        Journal journalFile = new Journal();
            
        // string promptSelection = "";

        while (userSelection != 5)
        {
            Console.WriteLine("What option do you select?");
            Console.WriteLine("1. New journal entry");
            Console.WriteLine("2. Read journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Close journal");
            
            
            string userSelectionString = Console.ReadLine();
            userSelection = int.Parse(userSelectionString);

            // add spacer to separate instances
            /*BLANK LINE*/Console.WriteLine("");
            
            // journalFile._journalEntries = new List<string>();

            // journalFile._journalEntries.Add("THIS IS A TEST");

            
            // PromptGenerator newPrompt = new PromptGenerator();

            if (userSelection == 1)
            {
                /*BLANK LINE*/Console.WriteLine("");

                Entry newEntry = new Entry();
            
                PromptGenerator newPrompt = new PromptGenerator();

                Console.WriteLine("Option 1: New Entry");

                // Call the random Prompt
                newEntry._prompt = newPrompt.RandomPrompt();

                // TEST PROMPT GENERATION
                Console.WriteLine(newEntry._prompt);
                
                // Read the new entry responding to the prompt
                newEntry._journalEntry = Console.ReadLine();

                // Call the datetime
                newEntry._dateString = newEntry.GetDateTime();

                // TEST DATETIME READING
                Console.WriteLine(newEntry._dateString);

                journalFile.AddEntry(newEntry);

                // string newEntryFull = $"[{newEntry._dateString}] {newEntry._prompt}: \n{newEntry._journalEntry}";

                // // TEST NEW ENTRY DATA
                // Console.WriteLine(newEntryFull);

                // // ADD newENTRYFULL to the current List of Entries
                // journalFile._journalEntries.Add(newEntryFull);

                /*BLANK LINE*/Console.WriteLine("");
            }

            else if (userSelection == 2)
            {
                /*BLANK LINE*/Console.WriteLine("");

                Console.WriteLine("Option 2: Full Journal printout");

                // PRINT THE FULL CURRENTLY-LOADED JOURNAL
                // foreach (string i in journalFile._journalEntries)
                // {
                //     Console.WriteLine(i);
                // }

                journalFile.DisplayAllEntries();


            }

            else if (userSelection == 3)
            {
                /*BLANK LINE*/Console.WriteLine("");

                Console.WriteLine("Option 3: Save Journal.\nWhat is the name of the journal?");

                // Grab filename
                journalFile._fileName = Console.ReadLine();
                // SAVE FILE
                journalFile.SaveFile();

            }

            else if (userSelection == 4)
            {
                /*BLANK LINE*/Console.WriteLine("");

                Console.WriteLine("Option 4: Load Journal.\nWhat is the name of the journal?");

                // Grab filename
                journalFile._fileName = Console.ReadLine();
                // LOAD FILE
                journalFile.LoadFile();

            }

            else if (userSelection == 5){
                /*BLANK LINE*/Console.WriteLine("");

                Console.WriteLine("Option 5: End program.\n\nWould you like to save your journal?");
                string closeChoice = Console.ReadLine().ToLower();
                if (closeChoice == "yes")
                {
                    // SAVEFILE
                    Console.Write("Journal saved. Closing journal.");
                    // CURRENTLY THIS IS NOT TRUE, THE SAVE FEATURE IS NOT YET FUNCTIONING NOR ACTUALLY PLACED HERE.
                }


            }


            else //WHY DOESN"T THIS INCLUDE A BLANK VALUE FROM JUST HITTING ENTER?!
            {
                /*BLANK LINE*/Console.WriteLine("");
                Console.WriteLine("Sorry, that is not an option. Please select 1, 2, 3, or 4.");
                /*BLANK LINE*/Console.WriteLine("");
            }


        };

        /*BLANK LINE*/Console.WriteLine("");
    }
}