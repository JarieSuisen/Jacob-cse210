using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

public class Scripture
{
    // VARIABLES
    
    private List<Word> _wordList = new List<Word>();

    private Reference scriptureReference = new Reference();

    public void SetScriptureReference(string book, int chapter, int verse, int endVerse)
        {
         scriptureReference.SetReference(book, chapter, verse, endVerse);
        }

    // CONSTRUCTORS???
    public void SetScriptureText(string scriptureText)
    {
        
        // string scriptureText = "And now Behold the end is nigh but I am not but a humble fish. Oh, and WOW!!!!";

        // List<string> newText = new List<string>();

        List<string> newText = new List<string>(scriptureText.Split(" "));

        // TEST COUNT OF ITEMS IN LIST OF SCRIPTURE TEXT
        // Console.WriteLine($"THERE ARE {newText.Count} words in the scripture");

        // string[] scriptureWord = scriptureText.Split(" ");
        
        // for (int i = 0; i < newText.Count; i++)
        // {

        //     newText.Add(i);
        // }

        // CREATE NEW WORD ITEMS AND SET THE WORD
        for (int i = 0; i < newText.Count; i++)
        {
            Word newWord = new Word();
            newWord.SetText(newText[i]);
            // TESTING THE SET TEXT METHOD
            // Console.WriteLine($"The ADDED WORD IS: {newText[i]}");

            _wordList.Add(newWord);
        }
    }

    



    // METHODS
    
    public void HideRandomWords(int numberToHide)
    {
        
        // NEEDS TO PICK A RANDOM X ITEMS FROM THE LIST OF WORDS AND CALL THE SET THEM TO HIDDEN
        int listLength = _wordList.Count();
        
        // TESTING WORDLIST COUNT
        // Console.WriteLine($"The List Length is: {listLength}");

        // int listCount = 0;

        // TESTING LISTCOUNT
        // Console.WriteLine($"The List Length is: {listCount}");

        for (int i = numberToHide; i > 0; i--)
            {
                Random randomGenerator = new Random();
                int number = randomGenerator.Next(0, listLength);
                // Console.WriteLine($"The Random Number (word to be blanked) in the list is: {number}");
                _wordList[number].Hide();

            }


            // while (listLength >= listCount)
            // {
            //     Random randomGenerator = new Random();
            //     int number = randomGenerator.Next(0, listLength);
            //     // TESTING RANDOM NUMBER GENERATOR
            //     Console.WriteLine($"The Random Number is: {number}");

            //     _wordList[number].Hide();
            //     listCount ++;
            //     // TESTING ADJUSTED LISTCOUNT
            //     Console.WriteLine($"The List Length is: {listCount}");
            // }
    }

    public string GetDisplayText()
    {
        // Gets the Reference text
        string scriptureReferenceText = scriptureReference.GetDisplayText();

        // Gets the Verse Text
        string reformedScripture = "";
        // TEST WHAT IS IN WORDLIST
        for (int i = 0; i < _wordList.Count; i++)
        {
            string testingTESTING = _wordList[i].GetDisplayText();
            // TEST THE WORDLIST
            // Console.WriteLine($"THE WORDLIST CONTAINS {testingTESTING}");

            reformedScripture = reformedScripture + " " + testingTESTING;


        }

        // string reformedScripture = String.Join(" ", _wordList.GetDisplayText());

        // for (int i = 0; i < _wordList.Count; i++)
        // {
        //     Console.WriteLine($"The Pulled word is: {_wordList[i]}");

            
        string fullText = $"{scriptureReferenceText} {reformedScripture}";
        // }

        Console.WriteLine(fullText);

        return fullText;

    }

    public bool IsCompletelyHidden()
    {
        int listLength = _wordList.Count();

        int hiddenCount = 0;

        foreach (Word i in _wordList)
        {
            bool hiddenCheck = i.IsHidden();
            if (hiddenCheck == true)
            {
                hiddenCount ++;
            }
        }

        if (hiddenCount == listLength)
        {
            return true;
        }
        else
            return false;

    }













}