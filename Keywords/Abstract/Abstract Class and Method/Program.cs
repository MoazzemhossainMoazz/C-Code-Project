
//public abstract class
public class Animal
{

    //public abstract void MakeSound();
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal sound");
    }

    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}

public class Program
{
    public static void Main()
    {
        Animal animal = new Animal();
        animal.MakeSound();
        animal.Eat();

        Dog dog = new Dog();
        dog.MakeSound();
        dog.Eat();
    }
}