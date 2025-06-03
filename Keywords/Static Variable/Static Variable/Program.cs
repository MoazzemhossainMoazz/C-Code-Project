public class Student
{
    public static int TotalStudents = 0;

    public Student()
    {
        TotalStudents++;
    }
}

public class Program
{
    public static void Main()
    {
        new Student();
        new Student();
        new Student();
        Console.WriteLine("Total: " + Student.TotalStudents);
    }
}