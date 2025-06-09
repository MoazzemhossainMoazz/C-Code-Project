public class BaseClass
{
    public virtual void Greet()
    {
        Console.WriteLine("Hello from BaseClass");
    }
}
public class DerivedClass : BaseClass
{
    public override void Greet()
    {
        base.Greet();
        Console.WriteLine("Hello from Derivedclass");
    }
}

class Program()
{
    public static void Main()
    {
        BaseClass baseClass = new BaseClass();
        baseClass.Greet();

        DerivedClass derivedclass = new DerivedClass();
        derivedclass.Greet();

    }
}