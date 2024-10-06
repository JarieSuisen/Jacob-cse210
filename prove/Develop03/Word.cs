using System.Runtime.InteropServices.Marshalling;

public class Word
{
    // Variables
    private string _text = "";
    private bool _isHidden = false;

    // Methods
    public void Hide()
    {
        _isHidden = true;
        
        // Console.Write("____");
    }

    public void Show()
    {
        _isHidden = false;

        // Console.Write(_text);
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden == true)
        {
            _text = "___";
        }

        return _text;

    }

    // CONSTRUCTORS
    public void SetText(string word)
    {
        _text = word;
        _isHidden = false;
        
        // VERIFY WORD GOT SET
        // Console.WriteLine($"NEW WORD ADDED: {word}");
    }


}