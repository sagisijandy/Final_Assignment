using System.Data.Entity;



public class StudentContext : DbContext
{
    public DbSet<Student> Students { get; set; }
}