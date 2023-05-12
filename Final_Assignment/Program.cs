using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

using System.ComponentModel.DataAnnotations;

public class Student
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }
}



class Entity
{
    static void Main(string[] args)
    {
        using (var context = new StudentContext())
        {
            // Create a new student
            var student = new Student { Name = "John Doe" };

            // Add the student to the context
            context.Students.Add(student);

            // Save the changes to the database
            context.SaveChanges();

            Console.WriteLine("Student added successfully.");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
