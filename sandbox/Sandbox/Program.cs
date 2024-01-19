using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Write ");
        Console.WriteLine("2. Display ");
        Console.WriteLine("3. Load ");
        Console.WriteLine("4. Save ");
        Console.WriteLine("5. Quit ");
        string userResponse = Console.Readline();
        userNumber = int.Parse(userResponse);


    }

    static void DisplayResult(int args){
        if (args == 1){
            RandomPrompt()
        }
    }

    static string RandomPrompt(){
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1,3);

        string[] writingPrompt = new string[4];
        writingPrompt[1] = ("Are you taking enough risks in your life? Would you like to change your relationship to risk? If so, how?");
        writingPrompt[2] = ("At what point in your life have you had the highest self-esteem?");
        writingPrompt[3] = ("Consider and reflect on what might be your “favorite failure.”");

        if (randomNumber == 1){
            return writingPrompt[1];
        }
        else if (randomNumber == 2){
            return writingPrompt[2];
        }
        else {
            return writingPrompt[3];
        }
    }

}