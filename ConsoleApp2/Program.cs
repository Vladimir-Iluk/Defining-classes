using System;
using System.Runtime.InteropServices;

class Person
{
    private string name = "Undefined";
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    private int age;
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    public Person() : this("No name", 0)
    {

    }
    public Person(string name) : this(name, 1)
    {

    }
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
        Console.WriteLine($"Name - {name}, age - {age}");
    }
    public void print()
    {
        Console.WriteLine($"Name - {name}, age - {age}");
    }
}
class Program
{
    static void Main()
    {
        Person Pesho = new Person();
        //Pesho.print();
        Person Gosho = new Person("Gosho");
        //Gosho.print();
        Person Stamat = new Person("Stamat", 43);
        //Stamat.print();

    }
}