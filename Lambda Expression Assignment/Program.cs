using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of employees
        List<Employee2> employees = new List<Employee2>()
        {
            new Employee2() { Id = 1, FirstName = "Joe", LastName = "Smith" },
            new Employee2() { Id = 2, FirstName = "Sarah", LastName = "Laundry" },
            new Employee2() { Id = 3, FirstName = "Mike", LastName = "Tyson" },
            new Employee2() { Id = 4, FirstName = "Joe", LastName = "Williams" },
            new Employee2() { Id = 5, FirstName = "Emma", LastName = "Davis" },
            new Employee2() { Id = 6, FirstName = "Daniel", LastName = "Miller" },
            new Employee2() { Id = 7, FirstName = "Olivia", LastName = "Oille" },
            new Employee2() { Id = 8, FirstName = "James", LastName = "Bond" },
            new Employee2() { Id = 9, FirstName = "Sophia", LastName = "Taylor" },
            new Employee2() { Id = 10, FirstName = "Liam", LastName = "Anderson" }
        };

        // ---------------------------------------
        // FOREACH LOOP
        // Create list of employees named Joe
        // ---------------------------------------

        // Create empty list for employees named Joe
        List<Employee2> joeEmployees = new List<Employee2>();

        // Loop through each employee in the list
        foreach (Employee2 employee in employees)
        {
            // Check if employee first name is Joe
            if (employee.FirstName == "Joe")
            {
                // Add matching employee to new list
                joeEmployees.Add(employee);
            }
        }

        Console.WriteLine("Employees named Joe (foreach loop):");

        foreach (Employee2 employee in joeEmployees)
        {
            Console.WriteLine(employee.Id + " - " + employee.FirstName + " " + employee.LastName);
        }

        // ---------------------------------------
        // LAMBDA EXPRESSION
        // Create list of employees named Joe
        // ---------------------------------------

        // Used lambda expression to find employees named Joe
        List<Employee2> joeLambdaList = employees.Where(x => x.FirstName == "Joe").ToList();

        // Display employees found with lambda
        Console.WriteLine("\nEmployees named Joe (lambda expression):");

        foreach (Employee2 employee in joeLambdaList)
        {
            Console.WriteLine(employee.Id + " - " + employee.FirstName + " " + employee.LastName);
        }

        // ---------------------------------------
        // LAMBDA EXPRESSION
        // Find employees with Id greater than 5
        // ---------------------------------------

        // Create list of employees with Id > 5
        List<Employee2> highIdEmployees = employees.Where(x => x.Id > 5).ToList();

        // Display employees with Id greater than 5
        Console.WriteLine("\nEmployees with Id greater than 5:");

        foreach (Employee2 employee in highIdEmployees)
        {
            Console.WriteLine(employee.Id + " - " + employee.FirstName + " " + employee.LastName);
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}