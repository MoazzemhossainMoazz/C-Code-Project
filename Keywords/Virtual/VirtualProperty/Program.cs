public class Person
{
    public virtual string Name { get; set; } = "Unnamed";

}
public class Student: Person
{
    public override string Name { get; set; } = "Student";
}

class Program
{
    public static void Main()
    {
        Person p = new Person();
        Student s = new Student();

        Console.WriteLine(p.Name);
        Console.WriteLine(s.Name);
    }
}