namespace RNET104_100622024;

public class ClassForConstructor
{
    public string? name;
    public string? surname;
    public int age;
    public string? status;
    public string? IP;



    //Default, Parameterless və ya bizim dildə boş konstruktor.
    public ClassForConstructor()
	{
        Console.WriteLine("Parameterless");
        this.IP = "127.0.0.1";
	}

    //Constructor overloading.

    public ClassForConstructor(string name):this()
    {
        Console.WriteLine("1 Parameter");
        this.name = name;
    }

    public ClassForConstructor(string name, string surname):this(name)
    {
        Console.WriteLine("2 Parameters");
        this.surname = surname;
    }
    public ClassForConstructor(string name, string surname,int age) :this(name,surname)
    {
        Console.WriteLine("3 Parameters");
        this.age = age;
    }

    public ClassForConstructor(string name, string surname, int age, string status) : this(name,surname,age) 
    {
        Console.WriteLine("4 Parameters");
        this.status = status;
    }


}
