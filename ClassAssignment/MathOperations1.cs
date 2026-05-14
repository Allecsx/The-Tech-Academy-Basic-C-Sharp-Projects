using System;

// Static utility class that contains reusable math methods
public static class MathOperations1
{
    // --------------------------------------------------
    // METHOD 1
    // Takes an integer and returns the result using
    // an output parameter
    // --------------------------------------------------
    public static void DivideByTwo(int number, out int result)
    {
        // Perform calculation
        result = number / 2;
    }

    // --------------------------------------------------
    // OVERLOADED METHOD
    // Same method name but accepts a double instead
    // --------------------------------------------------
    public static void DivideByTwo(double number, out double result)
    {
        // Perform calculation
        result = number / 2;
    }
}