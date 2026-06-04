using System;

namespace StudentConsoleApp
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        // Navigation property for the one-to-many relationship
        public Grade Grade { get; set; }
    }
}

