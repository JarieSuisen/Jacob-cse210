// Class ID
public class Job
{

    // Variables; _camelCase = "";
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;

    // // Constructor... thing. Makes class callable? Nope
    // public Job()
    // {

    // }

    // Method (function) to do a thing. "public/private(?) OutputType NameInTitleCase()
    public void DisplayJobDetails()
    {
        
        // // FIXED TO CALL AS A SINGLE LINE
        // Console.WriteLine(_company);
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        // Console.WriteLine(_startYear);
        // Console.WriteLine(_endYear);
    }


}
