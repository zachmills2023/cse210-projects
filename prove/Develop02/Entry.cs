using System;

public class Entry{
    public string _date = DateTime.Now.ToString();
    public string _promptText{get;set;}
    public string _entryText{get;set;}

    // Use a constructor to take strings and make them Entry class.
    public Entry(string entryText,string promptText){
    _entryText = entryText;
    _promptText = promptText;
    }
    // Display the entry
    public void Display(){
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }

    // Format the details of the output to the txt file.
    public string FormatDetails(){
    return $"Date: {_date}|\nPrompt: {_promptText}|\nEntry: {_entryText}|";
    }
}