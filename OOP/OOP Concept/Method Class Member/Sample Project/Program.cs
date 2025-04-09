public class Student
{
    private string? _name;
    private DateTime _dateOfBirth;
    private string? _rollNumber;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public DateTime DateOfBirth
    {
        get { return _dateOfBirth; }
        set
        {
            if (value > DateTime.Now)
            {
                
                throw new ArgumentException("Date of birth can not be in the future");
            }
            _dateOfBirth = value;
        }
    }

    public string RollNumber
    {
        get { return _rollNumber; }
        set { _rollNumber = value; }
    }

    public Student(string name, DateTime dateOfBirth, string rollNumber)
    {
        Name = name;
        DateOfBirth = dateOfBirth;
        RollNumber = rollNumber;
    }

    private int CalculateAge()
    {
        int age = DateTime.Now.Year - DateOfBirth.Year;

        if(DateTime.Now < DateOfBirth.AddYears(age))
        {
            age--; 
        }
        return age;
    }

    public int Age
    {
        get { return CalculateAge(); }
    }

    
}

public class MyClass
{
    public static void Main(string[] args)
    {
        try
        {
            Student s1 = new Student("Moazz1", new DateTime(1990, 3, 30), "12200");
            Student s2 = new Student("Moazz2", new DateTime(1993, 3, 30), "12201");

            Console.WriteLine($"Student Details: ");
            Console.WriteLine($"Name: {s1.Name}, Date of Birth: {s1.DateOfBirth.ToShortDateString()}, Roll: {s1.RollNumber}, Age: {s1.Age}");
            Console.WriteLine($"Name: {s2.Name}, Roll: {s2.RollNumber}, Age: {s2.Age}");

        }
        catch(Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

    }
}
