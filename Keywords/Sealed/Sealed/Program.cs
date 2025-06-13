
public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal Speaking");
    }
}
public class Dog : Animal
{
    public sealed override void Speak()
    {
        Console.WriteLine("Dog Barking");
    }
}

//public class Cat : Dog
//{
//    public override void Speak()
//    {
//        Console.WriteLine("Cat Mew Mew");
//    }
//}


class Program
{
    public static void Main()
    {
        Animal animal = new Animal();
        animal.Speak();
        Dog dog = new Dog();
        dog.Speak();
    }
}