class Person
{
    public string name;

    protected int age;

    public void SetAge(int a)
    {
        age = a;
    }

    private void SetAge2(int a)
    {
        age = a;
    }

    public int GetAge()
    {
        SetAge2(2);
        return age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}

class Test
{
    public static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.name = "Arif";
        
        p1.SetAge(33);
        Console.WriteLine($"Name: {p1.name}, Age: {p1.GetAge()}");
        Console.WriteLine($"Age: {p1.GetAge()}");
    }
}