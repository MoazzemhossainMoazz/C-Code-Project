public class Person
{
    public virtual string Role => "Person";
}

public class Student : Person
{
    public override string Role => "Student";
}

public class Teacher : Student
{
    public override string Role { get; set; } = "Student";
}

class Program
{
    public static void Main()
    {
        Person p = new Person();
        Console.WriteLine(p.Role);

        Student s = new Student();
        Console.WriteLine(s.Role);

        Teacher t = new Teacher();
        Console.WriteLine(t.Role);
    }
}