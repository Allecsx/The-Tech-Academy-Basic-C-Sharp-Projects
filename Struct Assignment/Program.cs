using System;

// Created a struct called Number + property called Amount of type decimal
public struct Number
{
    public decimal Amount { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an object of type Number
        Number myNumber = new Number();

        // Assign a value to the Amount property
        myNumber.Amount = 123.45m;

        // Display the Amount value to the console
        Console.WriteLine("The amount is: " + myNumber.Amount);

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}