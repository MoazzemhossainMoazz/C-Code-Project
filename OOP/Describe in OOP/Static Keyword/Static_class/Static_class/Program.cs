using System;

static class Tutorial
{
    public static string Topics = "Static class";
}

public class Movie
{
     public string msg = "Not static class";
}

class program
{
    static void Main()
    {
        Movie movie = new Movie();
        
        Console.WriteLine("Topics name is: {0}", Tutorial.Topics);
        Console.WriteLine("Topics Name is: {0}", movie.msg);
    }
}