using System;
using System.Runtime.InteropServices;


    class Program
{
    static void Main()
    {
        Employee emp = new Employee();
        Console.WriteLine("Input how much employee in company - ");
        int n = int.Parse(Console.ReadLine());
        emp.addEmployees(n);
        string result = emp.DepartmentWithTopSallary();
        Console.WriteLine(result);
    }

}