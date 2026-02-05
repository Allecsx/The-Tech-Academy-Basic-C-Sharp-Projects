using System;

namespace MathOperations
{
    class Program
    {
        static void Main()
        {
            // 1.Ask the user for a number to multiply by 50
            // Using 'long' to be able handling numbers larger than 10,000,000
            Console.WriteLine("Enter a number to multiply by 50:");
            long multiplyInput = Convert.ToInt64(Console.ReadLine());

            // Multiply by 50
            long multiplyResult = multiplyInput * 50;

            // Display the result
            Console.WriteLine("Result: " + multiplyResult);



            // 2.Ask the user for a number to add 25 to
            Console.WriteLine("Enter a number to add 25:");
            long addInput = Convert.ToInt64(Console.ReadLine());

            // Add 25 to the input
            long addResult = addInput + 25;

            // Display the result
            Console.WriteLine("Result: " + addResult);



            // 3.Ask the user for a number to divide by 12.5
            Console.WriteLine("Enter a number to divide by 12.5:");
            double divideInput = Convert.ToDouble(Console.ReadLine());

            // Divide by 12.5
            double divideResult = divideInput / 12.5;

            // Display the result
            Console.WriteLine("Result: " + divideResult);



            // 4.Ask the user for a number to check if it is greater than 50
            Console.WriteLine("Enter a number to check if it is greater than 50:");
            int compareInput = Convert.ToInt32(Console.ReadLine());

            // Check if the number is greater than 50
            bool isGreaterThanFifty = compareInput > 50;

            // Display true or false
            Console.WriteLine(isGreaterThanFifty);



            // 5.Ask the user for a number to divide by 7 and get the remainder
            Console.WriteLine("Enter a number to divide by 7:");
            int remainderInput = Convert.ToInt32(Console.ReadLine());

            // Divide by 7 and store the remainder using the modulus operator
            int remainderResult = remainderInput % 7;

            // Display the remainder
            Console.WriteLine("Remainder: " + remainderResult);
        }
    }
}