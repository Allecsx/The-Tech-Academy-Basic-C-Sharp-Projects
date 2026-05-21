using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user to enter a number and read the input from the console
        Console.WriteLine("Enter a number:");
        string userNumber = Console.ReadLine();

        // Created file path where the text will be saved
        string filePath = @"C:\Users\alecs\Documents\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\Input Assignment\numbers.txt";

        // Insert the user's number into the text file
        File.WriteAllText(filePath, userNumber);

        // Read the contents of the text file
        string fileContents = File.ReadAllText(filePath);

        // Display the contents of the text file to the console
        Console.WriteLine("\nThe number saved in the text file is:");
        Console.WriteLine(fileContents);

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}