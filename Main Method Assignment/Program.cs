using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the MathOperations class
        MathOperations math = new MathOperations();

        // -------------------------------
        // CALL METHOD WITH INTEGER
        // -------------------------------

        // Pass an integer to the method
        int resultInt = math.DoMath(10);

        // Display result
        Console.WriteLine("Result using int: " + resultInt);

        // -------------------------------
        // CALL METHOD WITH DECIMAL
        // -------------------------------

        // Pass a decimal value (note the 'm' suffix)
        int resultDecimal = math.DoMath(4.5m);

        // Display result
        Console.WriteLine("Result using decimal: " + resultDecimal);

        // -------------------------------
        // CALL METHOD WITH STRING
        // -------------------------------

        // Pass a string that represents a number
        int resultString = math.DoMath("25");

        // Display result
        Console.WriteLine("Result using string: " + resultString);

        // Keep the console window open
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}