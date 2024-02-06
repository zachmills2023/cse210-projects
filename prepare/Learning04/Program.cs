using System;

class Program
{
    static void Main(string[] args)
    {
    // Construct the object then call the summary function.
    Assignment StudentAssignment = new Assignment("Samuel Bennet","Multiplication");
    string genSummary = StudentAssignment.GetSummary();
    Console.WriteLine(genSummary);

    MathAssignment StudentMathAssignment = new MathAssignment("Roberto Rodriguez","Fractions","Section 7.3", "Problems 8-19");
    string mathSummary = StudentMathAssignment.GetHomeworkList();
    Console.WriteLine(mathSummary);

    WritingAssignment StudentWritingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
    Console.WriteLine(StudentWritingAssignment.GetWritingInformation());
    }

}