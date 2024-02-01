using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Starting sequence:
        Console.WriteLine("Press 'Enter' to continue.");
        Console.Write("> ");
        string input = Console.ReadLine();
        Console.Clear();
        // Next sequence:

        string file = "";
        while (file == "")
        {
            // Ask the user for the scripture file they would like to use:
            file = ReadFromFile();
        }

        /* Create a list to read in the contents to. Take the first line as
        the scripture reference. */
        string[] lines = File.ReadAllLines(file);
        // Return the formatted variables; declare var (they comprise str and int).
        Reference reference = ParseReference(lines);

        // Get the text of the scripture from the leftover lines data:
        string text = "";
        for (int i = 1; i < lines.Length; i++){
            text += lines[i] + Environment.NewLine;
        }
        
        Scripture targetScripture = new(reference, text);

        // Retrive the full scripture with it's reference:
        string scripture = targetScripture.GetDisplayText();

        // Display the scripture.
        Console.WriteLine(scripture);

        // Now you will need to loop a readline for any key to continue and have the program
        // take a 'q' to quit. Call all the right methods in order to hide the words each time
        // that the user types something to continue. 

        bool done = false;
        int wordsToHide = 3;
        while (done != true){
            
            Console.WriteLine("\nPress 'Enter' to continue, press 'q' or type 'quit' to exit.");
            Console.Write("> ");
            string continueInput = Console.ReadLine().ToLower();
            Console.Clear();
            // Allow the user to quit if they need to.
            if (continueInput == "q" || continueInput == "quit"){
                // End the program if the user decides to quit.
                done = true;
                return;
            }
            else{
                targetScripture.HideRandomWords(wordsToHide);
                scripture = targetScripture.GetDisplayText();
                Console.WriteLine(scripture);
                wordsToHide++;

                if (targetScripture.IsCompletelyHidden()){
                    return;
                }
            }
        }
    }

    /* Read raw txt data into a string from a user provided file. */
    public static string ReadFromFile()
    {
        // Prompt the user for the file name.
        Console.WriteLine("\nPlease type the filename for the scripture you would like to read from.\n" + 
        "(DO NOT include the filetype i.e. '.txt')");
        Console.Write("> ");
        string fileInput = Console.ReadLine();
        // Automatically append the file extension '.txt'.
        fileInput += ".txt";

        try
        {
            StreamReader sr = new(fileInput);
            // Return the file contents.
            return fileInput;
        }
        catch (Exception readError)
        {
            Console.WriteLine("\nThe file could not be read please check your"+
            "spelling and/or file location and try again.\n");
            // Display the type of error message.
            Console.WriteLine(readError.Message);
            return "";
        }
    }

    /* Clean up the first line of the user-provided scripture file 
    then return the reference object variable. */ 
    public static Reference ParseReference(string[] lines){
        // Chop up the first line of the string based on the special characters mentioned below,
        // then remove them. 
        string referenceLine = lines[0];
        string[] parts = referenceLine.Split(new[] {'|', ':', '-'}, StringSplitOptions.RemoveEmptyEntries);
        // Remove the whitespaces using the Trim() method below.
        string book = parts[0].Trim();
        int chapter = int.Parse(parts[1].Trim());
        int startVerse = int.Parse(parts[2].Trim());
        int endVerse = 0;
        // If a dash is used to show mult. verses, show the end verse as that number listed. 
        if (lines[0].Contains('-')){
            endVerse = int.Parse(parts[3].Trim());
        }
        // If endVerse does not exist (other than initializing value) return the object without it.
        if (endVerse == 0){
            Reference ScriptureReference = new(book,chapter,startVerse,endVerse);
            return ScriptureReference;
        }
        else{
           Reference ScriptureReference = new(book, chapter, startVerse);
           return ScriptureReference;
        }
    }
}
