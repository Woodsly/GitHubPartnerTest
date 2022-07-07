using GithubPartnertest;


Employee a = new Employee("Vinh", 1000000, "model student!");
Employee b = new Employee("Connor", 1000000, "ace");
Employee c = new Employee("Matt", 1000000, "valorant");
Employee x = new Employee("Justin", 100000, "best teacher, I hope you're reading this!");
Employee y = new Employee("Josh", 200000, "best TA");

List<Employee> list = new List<Employee>();


list.Add(a);
list.Add(b);
list.Add(c);
list.Add(x);
list.Add(y);

foreach(Employee e in list)
{
    Console.WriteLine($"Name:{e.Name} Salary: {e.Salary} Role: {e.role}");
}

//This is your job. Get rid of things you should get rid of.