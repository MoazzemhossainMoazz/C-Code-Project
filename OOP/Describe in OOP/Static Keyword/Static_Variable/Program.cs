using System;

class Vehicle
{
    public static string Model_color = "Black";
}

class program
{
    static public void Main()
    {
        Console.WriteLine("This car color is: {0}", Vehicle.Model_color);
    }
}