using System;


//Use Top level Statement, when I don't use the main method
//var AC = new Car();
//AC.Accelerate();
//AC.Break();

public class Car
{
    private int speed = 0;

    public int Speed
    {
        get { return speed; }
    }

    public void Accelerate()
    {
        if (speed < 200)
        {
            speed += 10;
            Console.WriteLine($"Car accelerated. Speed: {speed} km/h");
        }
        else
        {
            Console.WriteLine("Maximum speed reached!");
        }
    }

    public void Break()
    {
        if(speed > 0)
        {
            speed -= 10;
            Console.WriteLine($"Car slower down Speed: {speed} km/h");
        }
        else
        {
            Console.WriteLine("Car is already stopped.");
        }
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.Accelerate();
        myCar.Break();
        Console.WriteLine($"Current Speed: {myCar.Speed} km/h");
    }
}




