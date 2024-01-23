using System;
using System.Collections.Generic;
using System.IO;

public class Journal{
    // Initialize the _entries attribute as a string list. 
    public List<Entry> _entries;

    // Create a constructor for the Journal class.
    public Journal(){
        _entries = new List<Entry>();
    }

    // This will be the funtion used to add an entry to a single 
    // file before or after it is saved to a file.  
    public void AddEntry(Entry newEntry){
        _entries.Add(newEntry);
    }

    // This will be used to display all entries in the currently used txt file.
    public void DisplayAll(){
        foreach (Entry entry in _entries){
            entry.Display();
        }
    }

    // This will be used to save the entries to one file.
    // Use the fileName argument to be passed in from main() as user input.
    public void SaveToFile(string fileName){
        
        using (StreamWriter outputFile = new StreamWriter(fileName)){

            foreach (Entry entry in _entries){
                outputFile.WriteLine(entry.FormatDetails());
            }
        }
    }

    // This will be used to import entries from any .txt file saved previously.
    public void LoadFromFile(string file){
        if (File.Exists(file)){     
            string[] lines = File.ReadAllLines(file);
            for (int i = 0; i < lines.Length; i += 3){
                if (i + 2 < lines.Length){
                    string date = lines[i];
                    string prompt = lines[i + 1];
                    string entry = lines[i + 2];
                    Entry newEntry = new Entry(entry, prompt);
                    newEntry._date = date;
                    _entries.Add(newEntry);
                }
            }
        }
        else{
            Console.WriteLine("The file does not exist.");
        }
    }

}


