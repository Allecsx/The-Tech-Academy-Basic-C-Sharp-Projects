using System;

// This class contains a method with an optional parameter
public class MathOperations
{
    // Method that takes two integers, second one is optional (default = 5)
    public int AddNumbers(int num1, int num2 = 5)
    {
        // Perform a math operation (addition)
        return num1 + num2;
    }
}