using System;
using System.Runtime.Intrinsics.X86;

//var v1 = new Vehicle("x11");
//Console.WriteLine(Vehicle.InstanceCounter);
//Console.WriteLine(v1.modelName);

//var v2 = new Vehicle("x12");
//Console.WriteLine(Vehicle.InstanceCounter);
//Console.WriteLine(v2.modelName);

//var v3 = new Vehicle("x13");
//Console.WriteLine(Vehicle.InstanceCounter);
//Console.WriteLine(v3.modelName);


class Vehicle
{
    public static int InstanceCounter = 0;
    public string modelName;
    public Vehicle(string modelName) 
    {
        InstanceCounter += 1;
        this.modelName = modelName;
    }
}

class program()
{
    static void Main()
    {
        Vehicle veh1 = new Vehicle("X12");
        Console.WriteLine(Vehicle.InstanceCounter);
        Console.WriteLine(veh1.modelName);

        Vehicle veh2 = new Vehicle("X13");
        Console.WriteLine(Vehicle.InstanceCounter);
        Console.WriteLine(veh2.modelName);

        Vehicle veh3 = new Vehicle("X14");
        Console.WriteLine(Vehicle.InstanceCounter);
        Console.WriteLine(veh3.modelName);
    }
}



