using System;

namespace Task1;

public class Program
{
    public static void Main(string[] args)
    {
        //First Object
        Student s1 = new Student();
        s1.name = "Rajak";
        s1.age = 21;
        s1.grade = "C";
        
        //Second Object
        Student s2 = new Student();
        s2.name = "Saphal";
        s2.age = 22;
        s2.grade = "A";
        
        
        // Static field
        Console.WriteLine($"\nCollege Name: {Student.collegeName}");
        
        // Display values
        Console.WriteLine("=== Student 1 Details ===");
        Console.WriteLine($"Name: {s1.name}");
        Console.WriteLine($"Age: {s1.age}");
        Console.WriteLine($"Grade: {s1.grade}");

        Console.WriteLine("\n=== Student 2 Details ===");
        Console.WriteLine($"Name: {s2.name}");
        Console.WriteLine($"Age: {s2.age}");
        Console.WriteLine($"Grade: {s2.grade}");
    }
}