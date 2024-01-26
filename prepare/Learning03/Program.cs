using System;

class Program
{
    static void Main(string[] args)
    {
        // Calling the constructor with no parameters:
        Fraction fraction1 = new Fraction();
        // Get the fractionResult.
        string fractionResult1 = fraction1.GetFractionString();
        // Get the decimal result.
        double decimalResult1 = fraction1.GetDecimalValue();
        // Display the results:
        Console.WriteLine("Fraction form: " + fractionResult1 + "\n" +
                          "Decimal form: " + decimalResult1 + "\n");


        // Initialize parameters:
        int wholeNumber = 5;
        // Calling the constructor with one parameter:
        Fraction fraction2 = new Fraction(wholeNumber);
        // Get the fractionResult.
        string fractionResult2 = fraction2.GetFractionString();
        //Get the decimalResult.
        double decimalResult2 = fraction2.GetDecimalValue();
        // Display results:
        Console.WriteLine("Fraction form: " + fractionResult2 + "\n" +
                          "Decimal form: " + decimalResult2 + "\n");

        // Initialize the parameters for the constructor with two parameters:
        int top = 3;
        int bottom = 4;
        // Initialize the object by calling the constructor.
        Fraction fraction3 = new Fraction(top, bottom);
        // Get the fractionResult.
        string fractionResult3 = fraction3.GetFractionString();
        // Get the decimalResult.
        double decimalResult3 = fraction3.GetDecimalValue();
        // Display:
        Console.WriteLine("Fraction form: " + fractionResult3 + "\n" +
                          "Decimal form: " + decimalResult3 + "\n");

        // Reset same parameters for final test case:
        top = 1;
        bottom = 3;
        // Initialize new object for the final test case.
        Fraction fraction4 = new Fraction(top,bottom);
        // Get the fractionResult.
        string fractionResult4 = fraction4.GetFractionString();
        // Get the decimalResult.
        double decimalResult4 = fraction4.GetDecimalValue();
        // Display final test case:
        Console.WriteLine("Fraction form: " + fractionResult4 + "\n" +
                          "Decimal form: " + decimalResult4 + "\n");


    }
}