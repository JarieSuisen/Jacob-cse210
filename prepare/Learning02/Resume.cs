public class Resume
{

    // Variables; _camelCase = "";

    public string _nameFirst = "";
    public string _nameLast = "";

    // This one makes a list.
    public List<Job> _jobList = new List<Job>();


    // Method (function) to do a thing. "public/private(?) OutputType NameInTitleCase()

    public void ResumePrintout()
    {

        Console.WriteLine($"Name: {_nameFirst} {_nameLast}");
        Console.WriteLine("Jobs:");

        // // Oh... this was the hard way and not quite right even though it called the same end result in the terminal.
        // for (int i = 0; i < _jobList.Count; i++)
        // {
        //     Console.WriteLine($"{_jobList[i]._jobTitle} ({_jobList[i]._company}) {_jobList[i]._startYear}-{_jobList[i]._endYear}");
        // }
        foreach (Job i in _jobList)
        {
            i.DisplayJobDetails();
        }

    }




}