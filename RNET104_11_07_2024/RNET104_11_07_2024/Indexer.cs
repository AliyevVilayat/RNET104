namespace RNET104_11_07_2024;

public class Indexer
{
    public int[] arr;

    public int this[int index] { get { return arr[index]; } set { arr[index] = value; } }


    /*private int _age;
    public int Age
    {
        get
        {
            return _age;
        }
        set
        {
            if (value < 0)
            {
                throw new Exception("0 dan kicik deyer gonderile bilmez");
            }
            else { _age = value; }
        }
    }

    public void TestProperty()
    {
        _age = 1;
        int age = _age;
    }*/
}


public class Department
{
    // public RType this[int index] {get{}; set{};}
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Employee> Employees { get; set; }

    public Employee this[int index]
    {
        get
        {
            return Employees[index];
        }
        set
        {
            if (value.Name != null)
            {
                Employees[index] = value;
            }
            else
            {
                Console.WriteLine("Employee name is null, pls try again.");
            }
        }
    }
}


public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }

}
