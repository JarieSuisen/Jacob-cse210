public class Journal
{

    // List of journal entries that are saved/loaded
    public List<Entry> _journalEntries = new List<Entry>();

    // Name of file being saved/loaded

    public string _fileName = "";

    
    public void AddEntry(Entry newEntry)
    {
        _journalEntries.Add(newEntry);
        Console.WriteLine("Added Entry (I hope)");
        
        Console.WriteLine(_journalEntries.Count());
    }

    public void DisplayAllEntries()
    {

        Console.WriteLine(_journalEntries.Count());

        foreach (Entry i in _journalEntries)
        {
            i.DisplayEntry();
        }
    }


    // Method: SAVE FILE
    public void SaveFile()
    {
        // string fileName = _fileName;
        using (StreamWriter outputFile = new StreamWriter($"{_fileName}.json"))
        {
        
            // ADJUST THE FOLLOWING TO ACTUALLY DO WHAT I NEED
        
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("This will be the first line in the file.");
            
            // You can use the $ and include variables just like with Console.WriteLine
            string color = "Blue";
            outputFile.WriteLine($"My favorite color is {color}");

            outputFile.Close();
        }
    }




    // Method: LOAD FILE
    public void LoadFile()
    {
        try
        {       
           
            // string fileName = _fileName;

            string[] lines = System.IO.File.ReadAllLines($"{_fileName}.json");


            // ADJUST THE FOLLOWING TO ACTUALLY DO WHAT I NEED
            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                string firstName = parts[0];
                string lastName = parts[1];
            }

        // CLOSE FILE???

        }
        finally
        {
            Console.WriteLine("The file does not exist.");
        }
    }   

}