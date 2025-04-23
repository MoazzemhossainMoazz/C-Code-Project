//class Program
//{
//    static void Main()
//    {
//        List<String> food = new List<String>();

//        food.Add("Pzza");
//        food.Add("Burger");
//        food.Add("Sandwitch");
//        food.Add("Pasta");

//        //food.Add("Rice");
//        //food.Remove("Pzza");
//        //food.Insert(2, "sushi");
//        //Console.WriteLine(food.Count);
//        //Console.WriteLine(food.IndexOf("Pzza"));
//        //Console.WriteLine(food.LastIndexOf("Pasta"));
//        //Console.WriteLine(food.Contains("Pzza"));
//        //food.Sort();
//        //food.Reverse();
//        //food.Clear();
//        string[] foodArray = food.ToArray();

//        foreach (string item in food)
//        {
//            Console.WriteLine(item);
//        }
       
//    }
//}



using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Program
{
    static void Main()
    {
        List<int> List1 = new List<int>();

        int input;

        while (true)
        {

            Console.Write("Enter value: ");
            input = int.Parse(Console.ReadLine());

            if (input == 0)
                break;

            List1.Add(input);
        }

        for (int i = 0; i < List1.Count; i++)
        {
            for (int j = 0; j < List1.Count; j++)
            {
                if (List1[i] > List1[j])
                {
                    int temp = List1[j];
                    List1[j] = List1[i];
                    List1[i] = temp;
                }
            }
        }

        Console.WriteLine("\nYou entered:");

        foreach (int item in List1)
        {
            Console.WriteLine(item);
        }
    



        //---------------------------------------------------

        //    List<int> num1 = new List<int>();
        //    List<int> num2 = new ();
        //    List<int> num3 = new() { 1, 2, 3};
        //    Console.WriteLine(num3[1]);
        //    //var num4 = new ();
        //    List<int> num4 = new List<int>();
        //    var p1 = new Person("john", 20);
        //    var p2 = new Person("Doe", 25);
        //    var p3 = new Person("jack", 30);

        //    var persons = new List<Person>() { p1, p2};
        //    persons.Add(p3);

        //    Console.WriteLine(persons[1].getName());

        //}

        //class Person
        //{
        //    private string _name;
        //    private int _age;
        //    public Person(string name, int age)
        //    {
        //        _name = name;
        //        _age = age;
        //    }

        //    public string getName()
        //    {
        //        return _name;
        //    }
        //    public int getAge()
        //    {
        //        return _age;
        //    }

        //    public void setName(string name)
        //    { 
        //        _name=name;
        //    }

        //    public void setAge(int age) 
        //    {
        //        _age = age;
        //    }

        //------------------------------------
    }
}
