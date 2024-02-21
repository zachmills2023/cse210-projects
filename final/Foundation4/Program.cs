using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store the activities in.
        List<Activity> activities = new();

        // Create the activities and add them to a list.
        Activity running = new Running(DateTime.Today, 30, 3.0);
        activities.Add(running);

        Activity swimming = new Swimming(DateTime.Today.AddDays(2), 45, 30);
        activities.Add(swimming);

        Activity cycling = new Cycling(DateTime.Today.AddDays(1), 60, 15.0);
        activities.Add(cycling);

        // Display the summary for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}