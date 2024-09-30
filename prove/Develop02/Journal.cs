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

        // TESTING IF THIS WORKS
        Console.WriteLine("");
        Console.WriteLine("from Journals.AddEntry: Added Entry (I hope)");
        Console.WriteLine($"From Journals.AddEntry: Current count of entries: {_journalEntries.Count()}");
    }

    public void DisplayAllEntries()
    {

        Console.WriteLine($"The current Jounral Entry count: {_journalEntries.Count()}");

        foreach (Entry i in _journalEntries)
        {
            i.DisplayEntry();
        }
    }


    // Method: SAVE FILE
    public void SaveFile(string filename)
    {
        

// TESTING JUST A TEXT FILE    WHY DOES _journalEntries ALWAYS PRINT BLANK?!
        using (StreamWriter outputFile = new StreamWriter($"{filename}.txt"))
        {
            
            foreach (Entry i in _journalEntries)
            {
                outputFile.WriteLine(i);
            }
        }



/*
        // // ------- Convert data to jsonString

        string jsonString = JsonSerializer.Serialize(_journalEntries, new JsonSerializerOptions() { WriteIndented = true});  
        
        Console.WriteLine($"The JSON STRING IS: {jsonString} to be in file {filename} (FILE HAS NOT ACTUALLY BEEN CREATED)");

        // // OR

        string jsonString = JsonConvert.SerializeObject(_journalEntries.ToArray());
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
        try
        {       
           

        using (StreamReader r = new StreamReader($"{filename}.json"))  
        {  
            string json = r.ReadToEnd();  
            _journalEntries = JsonSerializer.Deserialize<List<Entry>>(json);  
        }  

        List<Entry> destination = _journalEntries.Select(d => new Entry  
        {
            // THESE MAY NEED UPDATED, I think the firest part is wrong, it needs to match the JSON identifiers
            _dateString = d._dateString,  
            _prompt = d._prompt,  
            _journalEntry = d._journalEntry,    
        }).ToList();  









        }
        finally
        {
            Console.WriteLine("The file does not exist.");
        }
    }   

}