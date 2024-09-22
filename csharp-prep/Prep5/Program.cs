using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");

        string userName = "";
        int userNumber = 0;
        int userSquareNumber = 0;

        static void WelcomePhrase()
        {
            Console.WriteLine("Welcome to the Programe!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            string inputNumber = Console.ReadLine();
            int number = int.Parse(inputNumber);
            return number;
        }

        static int SquareNumber(int x)
        {
            int square = x * x;

            return square;
        }

        static void DisplayResult(string word, int value)
        {
            Console.WriteLine($"{word}, the square of your number is {value}");
        }


        WelcomePhrase();
        userName = PromptUserName();
        userNumber = PromptUserNumber();
        userSquareNumber = SquareNumber(userNumber);
        DisplayResult(userName, userSquareNumber);


    }
}