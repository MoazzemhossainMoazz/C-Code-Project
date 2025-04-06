class Person
{
    //public string name;
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }

        // get; set; //use shortcut system
    }


    //public string Name  //Only for readable
    //{
    //    get { return name; }
    //}


    //public void Name //Only for writeable, here I use void because it has no return type value
    //{
    //    set { name = value; }
    //}

    public int Age
    {
        get { return age; }
        set { age = value; }

        // get; set; //use shortcut system
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, Age:{age}");
    }
}

class Test
{
    public static void Main(string[] args)
    {
        Person p1 = new Person();
        //p1.name = "Test name for variable"; //set value when using variable in another class 
        p1.Name = "Test name for Property"; //Set value using property
        p1.Age = 32;

        //Console.WriteLine($"Name: {p1.name}, Age: {p1.Age} "); //When variable declaration is "public string name;" in another class
        Console.WriteLine($"Name: {p1.Name}, Age: {p1.Age}"); //When use property
    }
}
