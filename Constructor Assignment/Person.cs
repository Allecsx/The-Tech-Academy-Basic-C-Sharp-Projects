using System;

namespace ConstructorAssignment
{
    public class Person
    {
        // Properties to store data
        public string Name { get; set; }
        public int Age { get; set; }

        // Takes name and chains to Constructor 2 with a default age (25)
        public Person(string name) : this(name, 25)
        {
            // This runs after Constructor 2 finishes
        }

        // Constructor 2 that directly assigns both values
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}