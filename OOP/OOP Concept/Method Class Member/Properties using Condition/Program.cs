using System.Security.Cryptography.X509Certificates;

class Person
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set 
        { 
            if(value.Length > 5)
            {
                name = value;
            }
        }
    }
    
    public int Age
    {
        get { return age; }
        set 
        {
            if (value > 0)
            {
                age = value;
            }
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.Name = "Test name using property";
        p1.Age = 10;
        p1.DisplayInfo(); //call output function

        Console.WriteLine($"Name: {p1.Name}, Age: {p1.Age}"); //direct use output function
    }
}


