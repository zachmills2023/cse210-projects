 using System;

// Ensure there are no duplicate questions for the 
// EXCEEDING REQUIREMENTS part of this assignment.

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name,string description,int duration) : base(name,description,duration)
    {
        _prompts = new List<string>
        {
            "Think about a moment of unexpected joy you experienced recently.",
            "Reflect on a new skill or hobby you picked up.",
            "Recall a conversation that changed your perspective.",
            "Consider a book or movie that deeply moved you.",
            "Remember a time when you felt truly at peace.",
            "Reflect on a goal you achieved.",
            "Think about a place you visited that left a lasting impression.",
            "Recall a moment when you were moved by nature's beauty."
        };

        _questions = new List<string>
        {        
            "What sparked it?",
            "How has it enriched your life?",
            "What was it about?",
            "Why did it resonate with you?",
            "Can you describe the setting and your feelings?",
            "How did you celebrate your accomplishment?",
            "What made it memorable?",
            "Where were you and what did you see?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage(_name);
        Console.WriteLine($"_description");
        Console.WriteLine("Please enter the amount of time you would like to reflect for:");
        Console.Write("> ");
        _duration = int.Parse(Console.ReadLine());
        DisplayPrompt();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
        }
        DisplayEndingMessage(_name,_duration);
    }

    public string GetRandomPrompt()
    {
        Random randomPrompt = new();
        int i = randomPrompt.Next(_prompts.Count);

        return _prompts[i];
    }

    public string GetRandomPromptQuestion()
    {
        Random randomPrompt = new();
        int i = randomPrompt.Next(_questions.Count);
        string question = _questions[i];
        // Remove it from this iteration of the outerloop so that 
        // it will not reappear in the same session.
        _questions.RemoveAt(i);

        return question;
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        ShowSpinner(4);
    }

    public void DisplayQuestions()
    {
        string question = GetRandomPromptQuestion();
        Console.WriteLine(question);
        ShowSpinner(4);
    }

}