//using System;

//public class Counter
//{
//    private int count = 0;

//    public Counter Increment()
//    {
//        count++;
//        return this;
//    }

//    public Counter Decrement()
//    {
//        if (count > 0)
//        {
//            count--;
//        }
//        else
//        {
//            Console.WriteLine("Count is already zero. Cannot decrement.");
//        }
//        return this;
//    }

//    public void Print()
//    {
//        Console.WriteLine("Current Count: " + count);
//    }

//    public static void Main()
//    {
//        Counter counter = new Counter();

//        Console.WriteLine("Enter number of times to increment:");
//        int incTimes = int.Parse(Console.ReadLine());

//        Console.WriteLine("Enter number of times to decrement:");
//        int decTimes = int.Parse(Console.ReadLine());

//        for (int i = 0; i < incTimes; i++)
//        {
//            counter.Increment();
//        }

//        for (int i = 0; i < decTimes; i++)
//        {
//            counter.Decrement();
//        }

//        counter.Print();
//    }
//}


using System;
public class Counter
{
    private int count = 0;

    public Counter Increment()
    {
        count++;
        return this;
    }
    public Counter Decrement()
    {
        if(count > 0)
        {
            count--;
        }
        else
        {
            Console.WriteLine("Count is already zero. so can not decrement.");
        }
        return this;
    }
    public void Print()
    {
        Console.WriteLine("Corrent count is: " + count);
    }

    public static void Main(string[] args)
    {
        Counter counter = new Counter();

        Console.WriteLine("Ente number of time to Increment: ");
        int incTimes = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number of tiem to Decrement: ");
        int decTimes = int.Parse(Console.ReadLine());

        for(int i=0; i<incTimes; i++)
        {
            counter.Increment();
        }
        for(int i=0; i<decTimes; i++)
        {
            counter.Decrement();
        }

        counter.Print();
    }
}