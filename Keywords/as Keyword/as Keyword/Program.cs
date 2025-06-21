class Animal { }
class Dog : Animal
{
    public void Bark() => Console.WriteLine("Woof!");
}

class Program
{
    public static void Main()
    {
        Animal pet = new Dog();
        Dog d = pet as Dog;

        if (d != null)
        {
            d.Bark();
        }
    }
}