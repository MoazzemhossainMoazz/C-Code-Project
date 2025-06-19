//class Program
//{
//    static void Main()
//    {
//        Type typeInfo = typeof(int);
//        Console.WriteLine(typeInfo.FullName);
//    }
//}


public class Person
{
    public string Name;
    public int Age;
}

class Program
{
    static void Main()
    {
        Type t = typeof(Person);

        Console.WriteLine("Type Name: " + t.Name);

        foreach(var field in t.GetFields())
        {
            Console.WriteLine("Field: " + field.Name + "(" + field.FieldType + ")");
        }
    }
}