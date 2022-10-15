
using Nesne_programlama_odev;

var employee1 = new Employee()
{
    Id = 1,
    Name = "Emre",
    Surname = "Demir",
    Salary = 5000
};
var employee2 = new Employee()
{
    Id = 2,
    Name = "Ahmet",
    Surname = "AAA",
    Salary = 6000
};

var manager = new EmployeeManager();
manager.Add(employee1);
manager.Remove(1);
manager.ListAll();