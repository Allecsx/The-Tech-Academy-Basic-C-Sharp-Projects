using System;

namespace StudentConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the database context using the using statement
            using (var db = new SchoolContext())
            {
                Console.WriteLine("Adding a new student to the database...");

                // Create a new Student instance named Bill
                var stud = new Student()
                {
                    StudentName = ""
                };

                // Add the student object to the database context
                db.Students.Add(stud);

                // Save changes to generate the database and insert the record
                db.SaveChanges();

                Console.WriteLine("Student 'Bill' saved successfully!");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}