class Student
{
    public string Name { get; set; }
}

class Program
{
    public static void Main()
    {
        object data = new Student { Name = "Anika" };

        if(data is Student s)
        {
            Console.WriteLine("Student name: " + s.Name);
        }
    }
}