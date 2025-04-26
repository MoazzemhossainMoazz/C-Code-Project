
class Program
{
    static void ChangeReferenceType(Student std2)
    {
        std2.studentName = "Steve";
        Console.WriteLine(std2.studentName);
    }

    static void Main(string[] args)
    {
        Student std1 = new Student();
        ChangeReferenceType(std1);
        std1.studentName = "Bill";
        Console.WriteLine(std1.studentName);
        
        ChangeReferenceType(std1);
        Console.WriteLine(std1.studentName);
    }
}

public class Student
{
    public string studentName;
}