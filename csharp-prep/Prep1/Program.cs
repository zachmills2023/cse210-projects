using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first given name? ");
        string givenName = Console.ReadLine();

        Console.WriteLine("What is your surname / last name? ");
        string surname = Console.ReadLine();

        Console.WriteLine($"Your name is {surname}, {givenName} {surname}.");
    }
}