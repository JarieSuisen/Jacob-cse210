using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage?");
        string stringPercent = Console.ReadLine();
        int intPercent = int.Parse(stringPercent);

        string letter = "";

        if (intPercent >= 90)
        {
            letter = "A"/*Console.WriteLine("Your grade is an A.")*/;
        }
        else if (intPercent >= 80)
        {
            letter = "B"/*Console.WriteLine("Your grade is a B.")*/;
        }
        else if (intPercent >= 70)
        {
            letter = "C"/*Console.WriteLine("Your grade is a C")*/;
        }
        else if (intPercent >= 60)
        {
            letter = "D"/*Console.WriteLine("Your grade is a D")*/;
        }
        else
        {
            letter = "F"/*Console.WriteLine("Your grade is an F")*/;
        }

        Console.WriteLine($"Your grade is a {letter}.");

        if (intPercent >= 60)
        {
            Console.WriteLine("Congratulations on passing!");
        }
        else
        {
            Console.WriteLine("Please try harder next time.");
        }


    }
}