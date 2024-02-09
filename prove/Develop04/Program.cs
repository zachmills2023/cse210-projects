using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string selection = "";
        bool done = false;

        // Display the menu with a sentinel control loop.
        while (!done)
        {
            Console.WriteLine("Please choose from the following mindfulness activities below:\n" +
            "1. Guided Breathing\n2. Guided Reflection\n3. Gratitude Listing");
            selection = Console.ReadLine();

            if (selection == "1")
            {
                BreathingActivity breathingActivity = new();
                breathingActivity.Run();

            }

            else if (selection == "2")
            {
                ReflectingActivity reflectingActivity = new("Reflecting", 
                "Often it is good to meditate and think about significant things that have happened to us\n" + 
                "That will be the focus of this activity. Try to ponder each of the prompts then the following questions.",
                60);
                reflectingActivity.Run();

            }

            else if (selection == "3")
            {
                int count = 0;
                List<string> prompts = new();

                ListingActivity listingActivity = new ListingActivity("Listing", 
                "This activity is a good way to \"count your blessings\". Many studies have demonstrated\n" +
                "the incredible mental and physical health benefits that can come from being grateful.\n"+
                "Please enter how long you would like the activity to go on for in seconds below:",
                60, count, prompts);

                listingActivity.Run();
            }

            else
            {
                Console.WriteLine("Sorry, that was invalid input. Please check the options above and try again.");
            }
        }
    }
}