using System;

public class PromptGenerator{
    
    static string[] _prompt = new string[]{
        "Are you taking enough risks in your life? Would you like to change your relationship to risk? If so, how?",
        "At what point in your life have you had the highest self-esteem?",
        "Consider and reflect on what might be your “favorite failure.”",
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion that I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public static string GetRandomPrompt(){
        Random randomGenerator = new Random();
        // Generate a random number between 0 and the length of the _prompt string.
        int randomNumber = randomGenerator.Next(0, _prompt.Length);
        return _prompt[randomNumber];
    }
}