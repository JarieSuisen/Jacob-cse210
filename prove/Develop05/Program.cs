using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {

        string selection = "";

        
        // Console.WriteLine("Hello Develop05 World!");

        while (selection != "4") //Or whatever the QUIT option is, loop the Activity menu
        {
            Console.Clear();
            
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start Breathing Activity");
            Console.WriteLine("   2. Start Reflection Activity");
            Console.WriteLine("   3. Start Listing Activity");
            Console.WriteLine("   4. Quit");
            Console.WriteLine();
            Console.WriteLine("Select a choice from the menu.");

            selection = Console.ReadLine();

            if (selection == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.setDetails();

                breathing.BreathingTime();
            
            
            }

            else if (selection == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.setDetails();
                reflection.SetList();
                
                reflection.ReflectionTime();
                
            
            
            }

            else if (selection == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.setDetails();
                listing.SetList();

                listing.ListingTime();
                
                
            }

            else
            {
                Console.WriteLine("Sorry, that is not a valid option.");
            }
            
        }

        Console.Clear();
        Console.WriteLine("Thank you, have a good day.");


        Console.WriteLine();
    }
}