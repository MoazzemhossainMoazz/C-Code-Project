using System.Reflection.Metadata.Ecma335;

class Person
{
    public string name;
    public int age;

    public Person()  //Default Constructor
    {
        name = "Rahim";
        age = 33;
    }

    public Person(string n, int a) //Paramiterise Constructor
    {
        name = n;
        age = a;
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
        p1.DisplayInfo();

        Person p2 = new Person("Sakib", 32);
        p2.DisplayInfo();

        Person p3 = new Person("Rakib", 34);
        p2.DisplayInfo();
    }
}