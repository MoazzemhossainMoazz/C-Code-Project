using System.Runtime.Serialization;

class Person
{
    public static string name1 = "Test";
    //public string name1 = "Test2"; //Similer name is not possible when already use a static variable name
    //static string name1 = "Test3"; //Similer name is not possible when already use a static variable name

    public string name2 = "Test2";
    public static string name3 = "Test3"; //when we don't use any access modifier in variable, but it is not working because the variable by default excess modifier is private
}

class PersonInfo
{
    public static void Main()
    {
        Person p2 = new Person();
        Console.WriteLine($"{Person.name1}");
        //Console.WriteLine($"{p2.name1}");
        //Console.WriteLine($"{Person.name1}");
        Console.WriteLine($"{p2.name2}");
        Console.WriteLine($"{Person.name3}");
}
}
