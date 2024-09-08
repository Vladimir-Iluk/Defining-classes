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
       
    
    public Person (string name, int age)
    {
        this.name = name;
        this.age = age;
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
        Person Pesho = new Person("Pesho", 20);
        Pesho.print();
        Person Gosho = new Person("Gosho", 18);
        Gosho.print();
        Person Stamat = new Person("Stamat", 43);
        Stamat.print();

    }
}