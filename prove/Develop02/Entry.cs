public class Entry
    {

        
        public string _dateString = "";
        
        public string _prompt = "";
        
        public string _journalEntry = "";

        

        public void DisplayEntry()
        {

            string entryLine = $"[{_dateString}] {_prompt}: \n{_journalEntry}";
            Console.WriteLine(entryLine);
            Console.WriteLine("");

        }

        public string GetDateTime()
        {
            DateTime theCurrentTime = DateTime.Now;
            string _dateText = theCurrentTime.ToShortDateString();
            return _dateText;
        }



    }