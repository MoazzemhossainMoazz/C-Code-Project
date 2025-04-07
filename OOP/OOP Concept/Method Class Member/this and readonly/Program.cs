using System.Security.Cryptography;

public class Student
{
    public readonly int age;

    public Student(int Age)
    {
        this.age = Age;
    }
}



public class MyClass()
{
   public static void Main(string[] args)
    {
        Student s1 = new Student(30);
        Console.WriteLine($"Age: {s1.age}");
    }
    
}