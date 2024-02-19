using System;

class Program
{
    static void Main(string[] args)
    {
        // Construct the object.
        GoalManager GM = new();

        // Create a list for goal objects (KEEP THIS LIST CONSTRUCTION OUTSIDE OF ANY LOOPS)
        List<Goal> GoalList = new();

        // Loop through the logic of the options.
        bool done = false;
        while (!done)
        {
            // Display the starting menu.
            GM.Start();
            // Get the user input.
            string startSelection = Console.ReadLine();

            GM.DisplayPlayerInfo();
            // Create New Goal
            if (startSelection == "1")
            {
                // Print the names of the goal types available.
                GM.ListGoalNames();
                string listSelection = Console.ReadLine();
                // Allow the user to create a new goal.
                GM.CreateGoal(listSelection,GoalList);
            }
            // List Goals
            else if (startSelection == "2")
            {
                GM.ListGoalDetails(GoalList,GM);
                Console.WriteLine("Type 'Enter' to continue.");
                Console.ReadLine();
            }
            // Save Goals
            else if (startSelection == "3")
            {
                GM.SaveGoals(GoalList);
            }
            // Load Goals
            else if (startSelection == "4")
            {
                GM.LoadGoals(GoalList);
            }
            // Record Event
            else if (startSelection == "5")
            {
                GM.RecordEvent(GoalList);
            }
            // Quit
            else if (startSelection == "6")
            {
                done = true;
            }
            else
            {
                Console.WriteLine("ERROR, please check that your input is in the valid range of 1 - 6 and try again.");
            }
        }    
    }
}