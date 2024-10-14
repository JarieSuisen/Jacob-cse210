using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // Console.WriteLine("Hello Learning05 World!");


        Assignment lastWeek = new Assignment();

        lastWeek.SetAssignment(
            "Charlie Chaplin",
            "Martial Arts"
        );
        Console.WriteLine(lastWeek.GetSummary());


        MathAssignment algebra = new MathAssignment();

        algebra.SetMathAssignment(
            "David Bowix",
            "Algebra",
            "1.7",
            "15-20"
        );

        Console.WriteLine(algebra.GetSummary());
        Console.WriteLine(algebra.GetHomeworkList());


        WritingAssignment writing = new WritingAssignment();

        writing.SetWritingAssignment(
            "Phil Conners",
            "Writing",
            "How to write and why I failed at it, vol. 3"
        );

        Console.WriteLine(writing.GetWritingInformation());



        Console.WriteLine();
    }
}