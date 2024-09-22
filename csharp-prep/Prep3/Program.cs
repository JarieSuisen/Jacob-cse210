using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");

        // Console.Write("What is the magic number?");
        // string strMagicNumber = Console.ReadLine();
        // int number = int.Parse(strMagicNumber);

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(-13,13);

        string strGuess = "";
        int guess = 0;
        int count = 0;

        do
        {
            Console.Write("what is your guess (range: -13 through 13)? ");
            strGuess = Console.ReadLine();
            guess = int.Parse(strGuess);
            
            count++;

            if (guess < number)
            {
                Console.Write("Higher, ");
            }
            else if (guess > number)
            {
                Console.Write("Lower, ");
            }
            else if (guess == number)
            {
                Console.Write($"You guessed it! It took you {count} attempts.");
            }
            else
            {
                Console.Write("That doesn't make sense.");
            }
            
        } while (guess != number);

    }
}