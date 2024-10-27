using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // Console.WriteLine("Hello Foundation3 World!");

        List<Activity> activities = new List<Activity>();

        Cycling cycling = new Cycling
        (
            "4 APR 2024", //date: "DD MMM YYYY"
            45, //duration: "X" minutes
            11 //speed: "X" mph
        );

        Running running = new Running
        (
            "29 FEB 2024", //date: "DD MMM YYYY"
            26, //duration: "X" minutes
            7 //distance: "X" miles
        );

        Swimming swimming = new Swimming
        (
            "13 OCT 2024", //date: "DD MMM YYYY"
            30, //duration: "X" minutes
            50 //laps: "X" laps
        );

        activities.Add(cycling);
        activities.Add(running);
        activities.Add(swimming);

        foreach (Activity i in activities)
        {
            Console.WriteLine();
            Console.WriteLine(i.GetSummary());

        }

        Console.WriteLine();
    }
}