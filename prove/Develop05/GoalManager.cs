using System;
using System.IO;

public class GoalManager
{
    // private List<Goal> _goals;
    private int _score;

    // Constructor for the GoalManager Object.
    public GoalManager()
    {}

    public int GetScore()
    {
        return _score;
    }
    public void SetScore(int score)
    {
        _score = score;
    }

    public void Start()
    {
        DisplayPlayerInfo();
        Console.WriteLine("Menu Options:\n   1. Create New Goal\n   2. List Goals\n" + 
        "   3. Save Goals\n   4. Load Goals\n   5. Record Event\n   6. Quit");
        Console.Write("Select a choice from the menu:");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points\n");
    }
    public void ListGoalNames()
    {
        Console.WriteLine("The types of Goals are:\n   1. Simple Goal\n   2. Eternal Goal\n   3. Checklist Goal\n");
        Console.Write("Which type of Goal would you like to create?: ");
    }

    public void ListGoalDetails(List<Goal> GoalList,GoalManager GM)
    {
        foreach (Goal goal in GoalList)
        {
            if (goal is SimpleGoal)
            {
                SimpleGoal SGoal = goal as SimpleGoal;
                string details = goal.GetDetailsString();
                Console.WriteLine(details);
            }
            else if (goal is EternalGoal)
            {
                EternalGoal EGoal = goal as EternalGoal;
                string details = goal.GetDetailsString();
                Console.WriteLine(details);
            }
            else // goal is ChecklistGoal
            {
                ChecklistGoal CGoal = goal as ChecklistGoal;
                string details = goal.GetDetailsString();
                Console.WriteLine(details);
            }
        }
        
    }

    public void CreateGoal(string listSelection,List<Goal> GoalList)
    {
        Console.WriteLine("What is the name of your goal?");
        string name = Console.ReadLine();
        Console.WriteLine("Please give a brief description:");
        string description = Console.ReadLine();
        Console.WriteLine("How many points will this be worth?");
        int points = int.Parse(Console.ReadLine());

        if (listSelection == "1")
        {
            bool isComplete = false;
            SimpleGoal SGoal = new(name,description,points,isComplete);
            // Have the name add a number to the end of it based on the order of the created goals.
            GoalList.Add(SGoal);
        }
        else if (listSelection == "2")
        {
            EternalGoal EGoal = new(name,description,points);
            GoalList.Add(EGoal);
        }
        else if (listSelection == "3")
        {
            Console.WriteLine("How many times will the goal need to be completed?");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("What will be the final bonus once the goal is completed met?");
            int bonus = int.Parse(Console.ReadLine());
            // Initialize the variable as 0 since it is a new object attribute and for the constructor.
            int amountCompleted = 0;
            ChecklistGoal CGoal = new(name,description,points,amountCompleted,target,bonus);
            GoalList.Add(CGoal);
        }
        else
        {
            Console.WriteLine("Input error. Please check the options and try again.");
        }
    }

    public void RecordEvent(List<Goal> GoalList)
    {
        // Display the list of goals for the user to choose from
        for (int i = 0; i < GoalList.Count; i++)
        {
            Console.WriteLine($"{i+1}. {GoalList[i].GetName}");
        }

        Console.Write("Select a goal from the list: ");
        int choice = int.Parse(Console.ReadLine());

        // Decrement choice by one so that it will be accurate to the index position.
        choice--;

        if (choice >= 0 && choice < GoalList.Count)
        {
            // choice is within the range of the list's count
            // Call the RecordEvent method of the selected goal
            GoalList[choice].RecordEvent(GoalList, this,choice);
        }
        else
        {
            Console.WriteLine("Invalid choice. Please select a number from the list.");
        }

    }


    // Save all current goals and progress into a txt file.
    public void SaveGoals(List<Goal> GoalList)
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        Console.WriteLine("Please enter the name of the file you would like the goals saved to.");
        string fileName = Console.ReadLine();

        string filePath = Path.Combine(currentDirectory,fileName);

        List<string> writeList = new();

        string scoreString = _score.ToString();
        string stringRepresentation = scoreString;
        writeList.Add(stringRepresentation);

        // This will iterate through each Goal object for each of the child class objects in the list.
        // It will call the GetStringRepresentation function for each object. 
        // It will then append each item in the list to it's own line.
        foreach (Goal goal in GoalList)
        {
            // This will call the method from each child class to get the specific representation for each of them.
            stringRepresentation = goal.GetStringRepresentation();
            
            writeList.Add(stringRepresentation);
        }
        // This will append each object to it's own line.
        foreach (string item in writeList)
        {
            File.AppendAllText(filePath, item + Environment.NewLine);
        }
    }

    // Load goals from an existing file. 
    public void LoadGoals(List<Goal> GoalList)
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        Console.WriteLine("Please enter the name of the file you would like to load the goals from.");
        string fileName = Console.ReadLine();

        string filePath = Path.Combine(currentDirectory, fileName);

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            string scoreString = lines[0];
            // Get the score from the first line of the file.
            _score = int.Parse(scoreString); 

            // Start from the second line
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(':');

                if (parts.Length > 0)
                {
                    switch (parts[0])
                    {
                        case "SimpleGoal":
                            SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                            GoalList.Add(simpleGoal);
                            break;
                        case "EternalGoal":
                            EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                            GoalList.Add(eternalGoal);
                            break;
                        case "ChecklistGoal":
                            ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
                                int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                            GoalList.Add(checklistGoal);
                            break;
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("File does not exist. Please ensure spelling and the file location and try again.");
            return;
        }
    }

}