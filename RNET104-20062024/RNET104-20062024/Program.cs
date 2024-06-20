using System.Linq.Expressions;

Func<string, string> funcUpperFirstLetter = name =>
{
    name = name.ToLower();
    name = name.Substring(0, 1).ToUpper() + name.Substring(1);
    return name;
};
Expression<Func<string, string>> expUpperFirstLetter = name => funcUpperFirstLetter(name);

Func<string, string> funcUpperCase = surname =>
{
    surname = surname.ToUpper();
    return surname;
};
Expression<Func<string, string>> expUpperCase = name => funcUpperCase(name);

Func<string, string, string> funcGenerateMail = (name, surname) => name + surname + "gmail.com";
Expression<Func<string, string, string>> expGenerateMail = (name, surname) => funcGenerateMail(name, surname);


List<Employee> employees = new List<Employee>()
{

    new Employee()
    {
        Name = "Name1",
        Surname = "Surname1"
    },

    new Employee()
    {
        Name = "Name2",
        Surname = "Surname2"
    },

    new Employee()
    {
        Name = "Name3",
        Surname = "Surname3"
    }
};

var employeDTOs = employees.Select(e => new EmployeeUserDTO
{
    Name = expUpperFirstLetter.Compile()(e.Name),
    Surname = expUpperCase.Compile()(e.Surname),
    Email = expGenerateMail.Compile()(e.Name, e.Surname)


});

class Employee
{
    public string Name { get; set; }
    public string Surname { get; set; }


}

class EmployeeUserDTO
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
}


/*Example for Hakim
 * Employee employe = new Employee()
{
    Name = "Name1",
    Surname = "Surname1"
};

Func<Employee, string> test = e => e.Name = "Test";

test(employe);
Console.WriteLine(employe.Name);*/