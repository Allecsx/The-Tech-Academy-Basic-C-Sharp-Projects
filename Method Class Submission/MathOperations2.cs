using System;

// Create a class that contains a void method
public class MathOperations2
{
    // Void method that takes two integer parameters
    public void DisplayNumbers(int num1, int num2)
    {
        // Perform a math operation on the first number
        int result = num1 * 2;

        // Display the result of the math operation
        Console.WriteLine("First number multiplied by 2: " + result);

        // Display the second number
        Console.WriteLine("Second number: " + num2);
    }
}
