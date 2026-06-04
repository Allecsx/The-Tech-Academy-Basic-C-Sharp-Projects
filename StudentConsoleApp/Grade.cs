using System.Collections.Generic;

namespace StudentConsoleApp
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }

        // Collection navigation property
        public ICollection<Student> Students { get; set; }
    }
}