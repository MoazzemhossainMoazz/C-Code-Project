public class Student
{
    private string name;

    public Student(string name)
    {
        this.name = name;
    }

    public void ShowName()
    {
        Console.WriteLine("Student name: " + this.name);
    }

    public static void Main()
    {
        Student s = new Student("Moazz");
        s.ShowName();
    }
}