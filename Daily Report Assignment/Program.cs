using System;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            // Printing the school name
            Console.WriteLine("Academy of Learning Career College");

            // Printing the title
            Console.WriteLine("Student Daily Report.");

            // Ask for the student's name = string
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();

            // Ask which course the student is on = string
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();

            // Ask for the current page number = integer
            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            // Ask if the student needs help = boolean
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            bool needsHelp = Convert.ToBoolean(Console.ReadLine());

            // Ask about positive experiences = string
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveExperience = Console.ReadLine();

            // Ask for any additional feedback = string
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string additionalFeedback = Console.ReadLine();

            // Ask how many hours the student studied = double
            Console.WriteLine("How many hours did you study today?");
            double hoursStudied = Convert.ToDouble(Console.ReadLine());

            // Print the closing message
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
        }
    }
