using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        int guess = -1;
    
        while (guess != magicNumber){
            Console.Write("What is the Magic Number? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess){
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess){
                Console.WriteLine("Lower");
            }
            else {
                Console.WriteLine("Correct! Great job!");
            }
            // Add a nested loop to count the number of guesses.

        }
    }
}