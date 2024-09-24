using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        // Console.WriteLine("Hello Learning02 World!");

        // Calls CLASS (Job)
        Job kittens = new Job();
            // Stores values to variables in CLASS (Job)
            kittens._company = "Pittsburg Weather";
            kittens._jobTitle = "Weatherman";
            kittens._startYear = 1985;
            kittens._endYear = 1996;

        Job carlise = new Job();
            carlise._company = "Lorwyn's New Rising";
            carlise._jobTitle = "Legendary Groundhog";
            carlise._startYear = 1888;
            carlise._endYear = 1984;

        // // TEST PRINT TO VERIFY THINGS WORK
        // Console.WriteLine($"I work for {kittens._company}.");
        // Console.WriteLine($"I work for {carlise._company}.");

        // // TEST PRINT TO VERIFY THINGS WORK
        // Console.WriteLine("First Job");
        // kittens.DisplayJobDetails();
        // Console.WriteLine("");
        // Console.WriteLine("Second Job");
        // carlise.DisplayJobDetails();


        Resume groundhogDay = new Resume();
            groundhogDay._nameFirst = "Phil";
            groundhogDay._nameLast = "Conners";
            // Calls LIST and adds content to it.
            groundhogDay._jobList.Add(kittens);
            groundhogDay._jobList.Add(carlise);

        // Console.WriteLine("");
        // Console.WriteLine(personOne._jobList[0]._jobTitle);

        groundhogDay.ResumePrintout();

        Console.WriteLine("");
        Console.WriteLine("END OF LINE");
        // FINALLY, it looks right.
    }

    

}