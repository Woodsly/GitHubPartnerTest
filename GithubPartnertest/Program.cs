using GithubPartnertest;

Employee x = new Employee("Justin", 100000);
Employee y = new Employee("Josh", 200000);

List<Employee> list = new List<Employee>();

list.Add(x);
list.Add(y);

//foreach(Employee e in list)
{
    Console.WriteLine($"Name:{e.Name} Salary: {e.Salary}");
}

//This is your job. Get rid of things you should get rid of.