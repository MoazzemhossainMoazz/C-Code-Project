

using System.Reflection.Metadata.Ecma335;

public class Counter
{
    private int count = 0;
    private List<string> history = new List<string>();
    private const string filePath = "counter.txt";

    public void Increment()
    {
        count++;
        Log("Incremented");
    }

    public void Decrement()
    {
        if (count > 0)
        {
            count--;
            Log("Decremented");
        }
        else
        {
            Log("Decrement failed (count=0)");
        }
    }

    public void Reset()
    {
        count = 0;
        Log("Reset");
    }

    public void Print()
    {
        Console.WriteLine("Correct Count = " + count);
    }

    public void ShowHistory()
    {
        Console.WriteLine("\n------Counter Histroy------");
        foreach (var item in history)
        {
            Console.WriteLine(item);
        }
    }

    public void Save()
    {
        File.WriteAllText(filePath, count.ToString());
        Log("Save to file");
    }

    public void Load()
    {
        if (File.Exists(filePath))
        {
            string text = File.ReadAllText(filePath);
            if (int.TryParse(text, out int value))
            {
                count = value;
                Log("Loaded from file");
            }
        }
    }

    private void Log(string action)
    {
        string entry = $"{DateTime.Now:HH:mm:ss} - {action} (count: {count})";
        history.Add(entry);
    }

    public class Program
    {
        public static void Main()
        {
            Counter counter = new Counter();
            counter.Load();

            while (true)
            {
                Console.WriteLine("\n1. Increment\n2. Decrement\n3. Print\n4. Reset\n5. Save\n6. Show History\n7. Exit");
                Console.WriteLine("Choose: ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": counter.Increment(); break;
                    case "2": counter.Decrement(); break;
                    case "3": counter.Print(); break;
                    case "4": counter.Reset(); break;
                    case "5": counter.Save(); break;
                    case "6": counter.ShowHistory(); break;
                    case "7": return;
                    default: Console.WriteLine("Invalid option."); break;
                }
            }
        }

    }
}