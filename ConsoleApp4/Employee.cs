class Employee
{
    public string name { get; set; }
    public int sallary { get; set; }
    public string posada { get; set; }
    public string viddil { get; set; }
    public string email { get; set; }
    public int age { get; set; }
    public Employee(string name, int sallary, string posada, string viddil, string email = "n/a", int age = -1)
    {
        this.name = name;
        this.sallary = sallary;
        this.posada = posada;
        this.viddil = viddil;
        this.email = email;
        this.age = age;
        //Console.WriteLine($"Name - {name};\n Sallary - {sallary};\n Posada - {posada};\n Viddil - {viddil};\n Email - {email};\n Age - {age}");


    }
    List<Employee> employees = new List<Employee>();
    public Employee() { }
    public void addEmployee(Employee employee)
    {
        employees.Add(employee);
    }
    public void addEmployees(int n)
    {
        for (int i = 0; i < n; i++)
        {

            Console.WriteLine("Name - ");
            string name = Console.ReadLine();
            Console.WriteLine("Sallary - ");
            int sallary = int.Parse(Console.ReadLine());
            Console.WriteLine("Posada - ");
            string posada = Console.ReadLine();
            Console.WriteLine("Viddil - ");
            string viddil = Console.ReadLine();
            Console.WriteLine("Email - ");
            string email = Console.ReadLine();
            Console.WriteLine("Age - ");
            int age = int.Parse(Console.ReadLine());
            Employee newEmployee = new Employee(name, sallary, posada, viddil, email, age);
            addEmployee(newEmployee);
        }
    }
    /*public void printEmployee(Employee)
    {
        Console.WriteLine($"Name - {name};\n Sallary - {sallary};\n Posada - {posada};\n Viddil - {viddil};\n Email - {email};\n Age - {age}" );
    }*/
    public string DepartmentWithTopSallary()
    {
        var departmentSallary = from e in employees
                                group e by e.viddil into departmentGroup
                                select new
                                {
                                    viddil = departmentGroup.Key,
                                    avgSallary = departmentGroup.Average(e => e.sallary)
                                };
        var topDepartment = departmentSallary
            .OrderByDescending(s => s.avgSallary)
            .FirstOrDefault();
        Console.WriteLine("Highest average sallary : ");
        if (topDepartment != null)
        {
            var employeesInTopDepartment = employees.Where(e => e.viddil == topDepartment.viddil).ToList();
            string result = "";
            foreach (var emp in employeesInTopDepartment)
            {
                result += $"Name - {emp.name}, sallary - {emp.sallary}, email - {emp.email}, age - {emp.age}\n";
            }

            return result;
        }
        else
        {
            return "No department found.";
        }
    }
}
