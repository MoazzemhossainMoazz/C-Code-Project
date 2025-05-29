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
        if(count < maxLimit)
        {
            count++;
        }
        else
        {
            Console.WriteLine($"Cannot increment. Max limit ({maxLimit})");
        }
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

    
}