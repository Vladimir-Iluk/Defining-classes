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
class Family : Person
{
    List<Person> members = new List<Person>();
    public Family() { }
    public void addMember(Person person )
    {
        members.Add( person );
    }
    public Person GetOldestMember()
    {
        Person oldestMember = members[0]; 
        for (int i = 1; i < members.Count; i++) 
        {
            if (members[i].Age > oldestMember.Age)
            {
                oldestMember = members[i]; 
            }
        }
        return oldestMember;
    }
    public void addMembers(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write("Input name - ");
            string name = Console.ReadLine();

            Console.Write("Input age - ");
            int age = int.Parse(Console.ReadLine()); 
            Person newMember = new Person(name, age);
            addMember(newMember);
        }
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
        Family Family = new Family();
        Console.WriteLine("Input how much members in family - ");
        int n=int.Parse(Console.ReadLine());
        Family.addMembers(n);
        Family.GetOldestMember();
    }
}