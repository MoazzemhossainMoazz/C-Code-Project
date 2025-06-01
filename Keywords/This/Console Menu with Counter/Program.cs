
public class Counter
{
    private int count = 0;
    private int maxLimit;

    public Counter(int maxLimit = 100)
    {
        this.maxLimit = maxLimit;
    }

    public Counter Increment()
    {
        if (count < maxLimit)
        {
            count++;
            Console.Write("Incremented. Current Count: " + count);
        }
        else
        {
            Console.WriteLine($"Cannot increment. Max limit ({maxLimit})");
        }
        return this;
    }

    public Counter Decrement()
    {
        if (count > 0)
        {
            count--;
            Console.Write("Decremented. Current Count: " + count);
        }
        else
        {
            Console.WriteLine("Count is already zero. Cannot decrement");
        }
        return this;
    }

    public Counter Reset()
    {
        count = 0;
        Console.WriteLine("Counter has been reset.");
        return this;
    }

    public void Print()
    {
        Console.WriteLine("Current Count: " + count);
    }

    public static void Main()
    {
        Counter counter = new Counter();

        while (true)
        {
            Console.WriteLine("\n=====Counter Menu=====");
            Console.WriteLine("1. Increment");
            Console.WriteLine("2. Decrement");
            Console.WriteLine("3. Show Count");
            Console.WriteLine("4. Reset");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    counter.Increment();
                    break;
                case "2":
                    counter.Decrement();
                    break;
                case "3":
                    counter.Print();
                    break;
                case "4":
                    counter.Reset();
                    break;
                case "5":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select 1-5.");
                    break;
            }
        }
    }
}


