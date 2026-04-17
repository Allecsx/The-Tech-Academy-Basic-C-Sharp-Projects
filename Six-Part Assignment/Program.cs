using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // =======================================
        // PART 1 - ARRAY + USER INPUT
        // =======================================

        // Create a one-dimensional array of strings
        string[] words = { "Hello", "Welcome", "Goodbye", "Morning", "Evening" };

        // Ask the user to input some text
        Console.WriteLine("PART 1: Enter text to append to each word:");
        string userInput = Console.ReadLine();

        // Append user input to each string
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i] + " " + userInput;
        }

        // Print updated array
        Console.WriteLine("\nUpdated words:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        // =======================================
        // PART 2 - INFINITE LOOP + FIX
        // =======================================

        /*
        // INFINITE LOOP (DO NOT RUN)
        while (true)
        {
            Console.WriteLine("This runs forever");
        }
        */

        // FIXED LOOP (stops when counter reaches array length)
        Console.WriteLine("\nPART 2: Fixed loop output:");
        int counter = 0;

        while (counter < words.Length)
        {
            Console.WriteLine(words[counter]);
            counter++;
        }

        // =======================================
        // PART 3 - < and <= LOOPS
        // =======================================

        Console.WriteLine("\nPART 3: Loop using <");
        for (int i = 0; i < words.Length; i++)
        {
            Console.WriteLine(words[i]);
        }

        Console.WriteLine("\nPART 3: Loop using <=");
        for (int i = 0; i <= words.Length - 1; i++)
        {
            Console.WriteLine(words[i]);
        }

        // =======================================
        // PART 4 - UNIQUE LIST SEARCH
        // =======================================

        List<string> colors = new List<string>()
        {
            "Red", "Blue", "Green", "Yellow", "Purple"
        };

        Console.WriteLine("\nPART 4: Search for a color:");
        string colorInput = Console.ReadLine();

        bool found = false;

        for (int i = 0; i < colors.Count; i++)
        {
            if (colors[i].Equals(colorInput, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Found at index: " + i);
                found = true;
                break; // stop after first match
            }
        }

        if (!found)
        {
            Console.WriteLine("Color not found.");
        }

        // =======================================
        // PART 5 - DUPLICATE SEARCH (MULTIPLE MATCHES)
        // =======================================

        List<string> fruits = new List<string>()
        {
            "Apple", "Banana", "Apple", "Cherry", "Banana", "Mango"
        };

        Console.WriteLine("\nPART 5: Search for a fruit:");
        string fruitInput = Console.ReadLine();

        bool matchFound = false;

        for (int i = 0; i < fruits.Count; i++)
        {
            if (fruits[i].Equals(fruitInput, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Match found at index: " + i);
                matchFound = true;
                // NO break → we want all matches
            }
        }

        if (!matchFound)
        {
            Console.WriteLine("Fruit not found.");
        }

        // =======================================
        // PART 6 - DETECT DUPLICATES
        // =======================================

        List<string> letters = new List<string>()
        {
            "A", "B", "C", "D", "C"
        };

        List<string> seenItems = new List<string>();

        Console.WriteLine("\nPART 6: Duplicate check:");

        foreach (string letter in letters)
        {
            if (seenItems.Contains(letter))
            {
                Console.WriteLine(letter + " - this item is a duplicate");
            }
            else
            {
                Console.WriteLine(letter + " - this item is unique");
                seenItems.Add(letter);
            }
        }

        // =======================================
        // END PROGRAM
        // =======================================

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}