namespace RNET104_100622024;

public class Department
{
    public List<Employee> Employees { get; set; }

    public Department()
    {
        Employees = new List<Employee>();
    }

    public void AddEmployee(Employee employee)
    {
        
        Employees.Add(employee);
    }
}
