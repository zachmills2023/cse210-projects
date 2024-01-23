using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {   


        bool done = false;
        string fileName = "";
        Entry newEntry = null;
        Journal myJournal = new Journal();

        while (done != true){   
            // Display the menu options for the user. 
            Console.WriteLine("1. Write \n2. Display\n3. Load\n4. Save\n5. Quit");
            // Get the user's selection and parse it to be an int.
            string userResponse = Console.ReadLine();
            int userNumber = int.Parse(userResponse);

            // 1. Write:
            if (userNumber == 1){
                // Call the random prompt method from the prompt generator class.
                // Store the returned prompt in the variable "prompt".
                string prompt = PromptGenerator.GetRandomPrompt();

                // Display the prompt.
                Console.WriteLine(prompt);
                // Take the user's input and store it in newEntry.
                Console.Write('>');
                string newEntryText = Console.ReadLine();
                // After the user hits "Enter", the response will be saved and they
                // Will return to the menu selection.
                newEntry = new Entry(newEntryText, prompt);

                myJournal.AddEntry(newEntry);
            } 

            // 2. Display
            else if (userNumber == 2){
                // Check if there are any entries in the journal.
                if (myJournal._entries.Count > 0){
                    // Display all entries in the journal.
                    myJournal.DisplayAll();
                } 
                // This means there are no entries to display:
                else{
                    Console.WriteLine("There don't seem to be any entries to display. " +
                    "Please load in a file or write some entries first.");
                }
            }

            // 3. Load
            else if (userNumber == 3){
                Console.WriteLine("Please enter the name of the file you would like to use below.");
                string searchFile = Console.ReadLine();
                // Get the relative path from the user's system and introduce the searchFile at the end
                // This way the user will not need to enter the entire path for this to work properly.
                string filePath = Path.Combine(Directory.GetCurrentDirectory(),searchFile);

                myJournal.LoadFromFile(filePath);

            }
            // 4. Save
            else if (userNumber == 4){
                Console.WriteLine("Please name the file. (Do not include the filetype," + 
                "\nthat will be assigned automatically as '.txt')");
                fileName = Console.ReadLine() + ".txt";
                // Use a flare below to quickly check the output in the console. 
                Console.WriteLine($"Filename: {fileName}\n");

                // Save the file using the user-entered filename.
                myJournal.SaveToFile(fileName);
            }
            // 5. Quit
            else if (userNumber == 5){
                // Set the sentinel loop control variable to 'true' to quit the loop.
                done = true;
            }
        }
    }
}