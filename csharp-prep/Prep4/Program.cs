using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers; type 0(zero) when finished.");

        List<int> listNumbers = new List<int>();

        int number = -999999999;

        do// while (number != 0)
        {
            
            Console.WriteLine("Enter number: ");
            string strNumber = Console.ReadLine();
            number = int.Parse(strNumber);
            if (number != 0)
            {
                listNumbers.Add(number);
            }

        }while (number != 0);

        Console.WriteLine("Your list is: ");
        for (int i = 0; i < listNumbers.Count; i++)
        {
            Console.Write($"{listNumbers[i]}, ");
        }
        Console.WriteLine();

        int sumNumbers = 0;
        for (int i = 0; i < listNumbers.Count; i++)
        {
            sumNumbers = sumNumbers + listNumbers[i];
        }
        float avgNumbers = sumNumbers/listNumbers.Count;
        int maxNumber = -999999999;
        for (int i = 0; i < listNumbers.Count; i++)
        {
            if (listNumbers[i]>maxNumber)
            {
                maxNumber = listNumbers[i];
            }
        }

        Console.WriteLine($"The sum of the list is: {sumNumbers}");
        Console.WriteLine($"The average is: {avgNumbers}");
        Console.WriteLine($"The largest number is: {maxNumber}");


    }
}