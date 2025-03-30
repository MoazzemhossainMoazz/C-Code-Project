using System;

static class Tutorial
{
    public static string Topics = "Static class";
}

public class  Movie
{

    public virtual void DoSomething()
    {
        System.Console.WriteLine("Hello TechnoArt - Do Something");
    }

    public static string nMsg1 = "This is Static Message";
    public string msg = "Not static class";
    public void WriteSomthing()
    {
        System.Console.WriteLine("Hello TechnoArt - Something");
    }

    public static void WriteAnything()
    {
        System.Console.WriteLine("Hello TechnoArt - Static Anything");
    }

    public static void WriteAnything(string Name1)
    {
        System.Console.WriteLine($"Hello TechnoArt - Static Anything {Name1}");
    }

}

public class Cinama: Movie
{
    public override void DoSomething()
    {
        System.Console.WriteLine("Hello TechnoArt - Overrided Do Something");
        base.DoSomething();
    }
}

class program
{
    static void Main()
    {
        Cinama movie1 = new Cinama();

        Console.WriteLine("Topics name is: {0}", Tutorial.Topics);
        Console.WriteLine("Topics Name is: {0}", movie1.msg);
        Console.WriteLine("Topics Name is: {0}", Movie.nMsg1);
        movie1.WriteSomthing();
        Movie.WriteAnything();
        Movie.WriteAnything("Times");
        movie1.DoSomething();

    }
}