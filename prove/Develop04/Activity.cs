using System;

public class Activity{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage(string name)
    {
        Console.WriteLine($"Alright, get ready for the {name} activity!\n");
    }

    public void DisplayEndingMessage(string name, int duration)
    {
        Console.WriteLine($"\nCongratulations! You completed {duration} seconds of the {name} activity!\n");
    }

    public void ShowSpinner(int seconds)
    {
        // Display a spinner.
        List<string> animationStrings = new List<string>();
        // |/-\
        animationStrings.Add("|");
        animationStrings.Add("\\");
        animationStrings.Add("-");
        animationStrings.Add("/");

        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }

        }
    }

    public void ShowCountDown(int seconds)
    {
        // Display a countdown timer with single digit numbers. 
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}