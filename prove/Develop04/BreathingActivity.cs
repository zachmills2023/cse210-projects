using System;

public class BreathingActivity : Activity{
    public BreathingActivity() 
        : base("Breathing", 
               "This activity is designed to help you focus on breathing and is a form of meditation.\n" +
               "In 2019, President Russell M. Nelson said, \"When Jesus asks you and me to 'repent,' He is inviting us" +
               "\nto change our mind, our knowledge, our spirit — even the way we breathe\"" + 
               "\nAs you noticed, it is important, both temporally and spiritually, to focus on our breath. This activity will" + 
               "\nguide you through a simple breathing exercise to help you get there.", 
               60)
    {
        // This constructor needs to stay blank here.
    }

    public void Run()
    {
        DisplayStartingMessage(_name);
        ShowSpinner(3);
        Console.WriteLine(_description);
        Console.WriteLine("\nPlease enter the amount of time you would like to do this for in seconds: ");
        Console.Write("> ");
        // Get the duration from user as an int by parsing Console.ReadLine()
        _duration = int.Parse(Console.ReadLine());

        // Get the current time so that the program will know how many rotations of these breatings countdowns to do.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        int count = 0;
        while (DateTime.Now < endTime)
        {
            if (count % 2 == 0)
            {
                Console.WriteLine("Breathe in for the first four seconds then hold.");
            }
            else
            {
                Console.WriteLine("Breathe out for the first four seconds then hold.");
            }
            // Call the method from the parent class for the countdown timer.
            ShowCountDown(8);
            count ++;
        }
        DisplayEndingMessage(_name,_duration);
    }
}
