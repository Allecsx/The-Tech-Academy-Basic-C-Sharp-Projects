using System.Data.Entity;

namespace StudentConsoleApp
{
    public class SchoolContext : DbContext
    {
        // Calls the base DbContext constructor
        public SchoolContext() : base()
        {
        }

        // Map our classes to database tables
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}