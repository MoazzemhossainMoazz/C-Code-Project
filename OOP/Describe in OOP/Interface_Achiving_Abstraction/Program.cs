interface IAnimal
{
    void MakeSound();
}

class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Dog Barks");
    }
}

class Cat : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        IAnimal myPet = new Dog();
        myPet.MakeSound();
        
    }
}