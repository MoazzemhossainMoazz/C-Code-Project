public abstract class Animal
{
    public abstract void MakeSound();

    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof! Woof!");
    }
}

public class Program
{
    public static void Main()
    {
        Dog dog = new Dog();
        dog.MakeSound();
        dog.Eat();
    }
}