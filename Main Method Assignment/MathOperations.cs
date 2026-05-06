using System;

// This class contains overloaded methods that perform math operations
public class MathOperations
{
    // Method 1: Takes an integer, adds 10, returns result as integer
    public int DoMath(int number)
    {
        return number + 10; // Simple addition
    }

    // Method 2: Takes a decimal, multiplies by 3, returns result as integer
    public int DoMath(decimal number)
    {
        // Multiply and cast to int (truncate decimal part)
        return (int)(number * 3);
    }

    // Method 3: Takes a string, converts it to an integer, subtracts 7, returns result
    public int DoMath(string number)
    {
        // Try to convert the string to an integer
        int parsedNumber = int.Parse(number);

        // Perform a different math operation
        return parsedNumber - 7;
    }
}