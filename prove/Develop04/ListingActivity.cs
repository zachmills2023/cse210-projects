using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name,string description,int duration, int count, List<string> prompts) 
    : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
    }

    public void Run()
    {
        // Display the startup message for the program.
        DisplayStartingMessage(_name);
        ShowSpinner(1);
        Console.WriteLine(_description);
        // Initialize all the objects and variables needed:
        Console.Write("> ");
        _duration = int.Parse(Console.ReadLine());
        List<string> EntryList = new();

        int _count = 0;
        // Display the prompt once outside the loop. 
        GetRandomPrompt();
        ShowSpinner(2);
        // Set the time after showing the prompt and spinner so the timer starts 
        // only after they have time to think about the prompt.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            GetListFromUser(EntryList);
            _count++;
        }
        Console.WriteLine($"You made {_count} entries!\n");
        DisplayEndingMessage(_name,_duration);
        ShowSpinner(1);
        Console.WriteLine("Would you like to save your entries? (Type \"1\" to save them OR press any key to continue without saving.)");
        Console.Write("> ");
        string saveInput = Console.ReadLine();
        if (saveInput == "1")
        {
            SaveListToFile(EntryList);
        }
        // End the method call if they type anything else.
        else
        {
            return;

        }
    }

    public void GetRandomPrompt()
    {
        // Generate a list of prompts.
        List<string> prompts = new();
        prompts.Add("Think of times you felt the Holy Ghost today.");
        prompts.Add("What is something small that happened today you are grateful for?");
        prompts.Add("Name a person in your life you are thankful for today. Why?");
        prompts.Add("What is a challenge you faced today that you're grateful for because it made you grow?");
        prompts.Add("Can you think of a moment of beauty you experienced today? What made it special?");
        prompts.Add("What is something in your surroundings right now that you're thankful for?");
        prompts.Add("Is there a personal skill or strength that helped you today? What was the situation?");
        prompts.Add("What is an aspect of your health or wellbeing you're grateful for today?");
        prompts.Add("Can you name a book, song, or movie you encountered recently that you're thankful for? How did it inspire you?");
        prompts.Add("In what ways did Heavenly Father bless you today");

        // Use Random to find a random index for a prompt from the list, 
        // then, display that prompt. 
        Random randomPrompt = new();
        int i = randomPrompt.Next(prompts.Count);
        Console.WriteLine(prompts[i]);
    }

    public List<string> GetListFromUser(List<string> EntryList)
    {
        Console.Write("> ");
        EntryList.Add(Console.ReadLine());

        return EntryList;
    }

    public void SaveListToFile(List<string> EntryList)
    {
        Console.WriteLine("Please name the file for your list of items" + 
        "\n(DO NOT include the filetype. ex. --> \".txt\").");
        Console.Write("> ");
        string filename = Console.ReadLine() + ".txt";

        // Save the file as a .txt file.
        File.WriteAllLines(filename, EntryList);
    }
}