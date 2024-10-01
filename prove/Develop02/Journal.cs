// using System;
// using System.Collections.Generic;
// using System.Web.UI;
// using System.Web.Script.Serialization;
using System.Text.Json;
using System.Xml.Serialization;
using Microsoft.VisualBasic;

public class Journal
{

    // List of journal entries that are saved/loaded
    public List<Entry> _journalEntries = new List<Entry>();

    // var _journalEntries = new List<Entry>();

    // Name of file being saved/loaded

    public string _fileName = "";

    
    public void AddEntry(Entry newEntry)
    {
        _journalEntries.Add(newEntry);

        // // TESTING IF THIS WORKS
        // Console.WriteLine("");
        // Console.WriteLine("from Journals.AddEntry: Added Entry (I hope)");
        // Console.WriteLine($"From Journals.AddEntry: Current count of entries: {_journalEntries.Count()}");
    }

    public void DisplayAllEntries()
    {

        // Console.WriteLine($"The current Jounral Entry count: {_journalEntries.Count()}");
        Console.WriteLine("");
        foreach (Entry i in _journalEntries)
        {
            i.DisplayEntry();
        }
    }


    // Method: SAVE FILE
    public void SaveFile(string filename)
    {
        


/**/
        using (StreamWriter outputFile = new StreamWriter($"{filename}.csv"))
        {
            
            // outputFile.WriteLine(_journalEntries);

            foreach (Entry i in _journalEntries)
            {
                string entryDate = $"{i._dateString}";
                string entryPrompt = $"{i._prompt}";
                string entryText = $"{i._journalEntry}";

                outputFile.WriteLine($"{entryDate},{entryPrompt},{entryText}");
            }
        }
/**/
        Console.WriteLine("");

// JSON DESIGN

/*
        // // ------- Convert data to jsonString

        string jsonString = JsonSerializer.Serialize(_journalEntries, new JsonSerializerOptions() { WriteIndented = true});  
        
        // IF DISABLING THE outputFile function, uncomment here to verify this is reached
        // Console.WriteLine($"The JSON STRING IS: {jsonString} to be in file {filename} (FILE HAS NOT ACTUALLY BEEN CREATED)");

        // // OR

        // string jsonString = JsonConvert.SerializeObject(_journalEntries.ToArray());
*/

        // // OR

        // var serializer = new JavaScriptSerializer();




/*
        // ------- Creates the file using the filename.
        using (StreamWriter outputFile = new StreamWriter($"{filename}.json"))  
        {  
            outputFile.WriteLine(jsonString);  
        }  
*/


    }




    // Method: LOAD FILE
    public void LoadFile(string filename)
    {
        string filenameLoad = $"{filename}.csv";
        try
        {       
           
            // START A NEW JOURNAL
            // Journal journalFile = new Journal();
            // List<Entry> journalFile = new List<Entry>();
            _journalEntries.Clear();


            // ADD TO NEW JOURNAL
            string[] lines = System.IO.File.ReadAllLines(filenameLoad);
            foreach (string line in lines)
            {
                Entry newEntry = new Entry();

                string[] parts = line.Split(",");

                string entryDate = parts[0];
                string entryPrompt = parts[1];
                string entryText = parts[2];

                newEntry._dateString = entryDate;
                newEntry._prompt = entryPrompt;
                newEntry._journalEntry = entryText;

                Console.WriteLine("This is the inserted journal:");
                Console.WriteLine(newEntry._dateString);
                Console.WriteLine(newEntry._prompt);
                Console.WriteLine(newEntry._journalEntry);

                _journalEntries.Add(newEntry);

            }

            // return journalFile;

/*
        using (StreamReader r = new StreamReader($"{filename}.json"))  
        {  
            string json = r.ReadToEnd();  
            _journalEntries = JsonSerializer.Deserialize<List<Entry>>(json);  
        }  

        List<Entry> destination = _journalEntries.Select(d => new Entry  
        {
            // THESE MAY NEED UPDATED, I think the first part is wrong, it needs to match the JSON identifiers
            _dateString = d._dateString,  
            _prompt = d._prompt,  
            _journalEntry = d._journalEntry,    
        }).ToList();  
*/








        }
        finally
        {
            // This was supposed to be so it would handle non-existing files, but it always prints. I'm not worrying about error fixing right now.
            // Console.WriteLine("The file does not exist.");
        }
        
    }   

}