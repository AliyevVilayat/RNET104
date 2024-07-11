
using RNET104_11_07_2024;


List<Employee> employees = new List<Employee>() 
{
    new Employee()
    {

        Id = 1,
        Name = "Employee1"
    },
    new Employee()
    {

        Id = 2,
        Name = "Employee2"
    },new Employee()
    {

        Id = 3,
        Name = "Employee3"
    }


};

Department department = new Department()
{
    Id = 1,
    Name = "Department1",
    Employees = employees

};

//Departmentdə çalışan 1ci employee gətir

Employee employee = department[1]; // =>  department.Employees[1];