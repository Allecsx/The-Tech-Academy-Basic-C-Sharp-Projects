using System;                 // Provides access to Console and basic system functions
using System.Text;            // Provides access to the StringBuilder class

class Program                 // Defines the main program class
{
    static void Main()        // Entry point of the console application
    {
        // --- CONCATENATE THREE STRINGS ---

        // Define three separate string variables
        string firstPart = "Learning ";
        string secondPart = "C# is ";
        string thirdPart = "fun!";

        // Concatenate (combine) the three strings into one
        string combined = firstPart + secondPart + thirdPart;

        // Display the concatenated result to the console
        Console.WriteLine("Concatenated string: " + combined);



        // --- CONVERT A STRING TO UPPERCASE ---

        // Convert the combined string to all uppercase letters
        string upperCaseVersion = combined.ToUpper();

        // Display the uppercase string
        Console.WriteLine("Uppercase version: " + upperCaseVersion);



        // --- CREATE A STRINGBUILDER AND BUILD A PARAGRAPH  ---

        // Create a new StringBuilder object
        // StringBuilder is efficient for building large or changing strings
        StringBuilder paragraph = new StringBuilder();

        // Append sentences one at a time to build a paragraph
        paragraph.Append("Jesse wants to write code. ");
        paragraph.Append("He should learn C#. ");
        paragraph.Append("And not stopping just to that one. ");
        paragraph.Append("There are many programming laguages which can very useful.");

        // Display the completed paragraph
        Console.WriteLine("\nParagraph built with StringBuilder:");
        Console.WriteLine(paragraph.ToString());

        // Pause the program so the console window stays open
        Console.ReadLine();
    }
}