

using System.Security.Cryptography.X509Certificates;

class Person
{
    //Variable/field, Property, Method

    public string name;
    public int age;

    public void SetValue(string n, int a)
    {
        name = n;
        age = a;
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
    
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
        
    }
    
}


class Program
{
    public static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.name = "Karim";
        p1.age = 35;
        p1.DisplayInfo();

        Person p2 = new Person();
        p2.name = "Rahim";
        p2.age = 40;
        Console.WriteLine($"Name: {p2.name}, Age: {p2.age}");
        p2.SetValue("Fahim", 36);

    }
    
}