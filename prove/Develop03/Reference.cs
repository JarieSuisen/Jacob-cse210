using System.Runtime.InteropServices;

public class Reference
    {
        // Variables
        private string _book = "";

        private int _chapter = 0;

        private int _verse = 0;

        private int _endVerse = 0;



        // Methods
        public string GetDisplayText()
        {
            string referenceText = "";
            if (_endVerse == 0)
            {
                referenceText = $"{_book} {_chapter}:{_verse}";
            }
            else
            {
                referenceText = $"{_book} {_chapter}:{_verse}-{_endVerse}";
            }

            // TEST IF GET DISPLAY TEXT IS WORKING
            // Console.WriteLine($"GETDISPLAYTEXT IS RETURNING: {referenceText}");
            return referenceText;
        }

        public void SetReference(string book, int chapter, int verse, int endVerse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _endVerse = endVerse;



            // TEST THE SETTING REFERENCE
            // Console.WriteLine($"THE SET REFERENCE IS: {_book} {_chapter}:{_verse}-{_endVerse}");
        }


    }