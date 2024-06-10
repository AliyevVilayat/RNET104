namespace RNET104_10062024_2;

public class Vehicle
{
    private static int _id = 0;
    public int Id { get; set; } 
    public string Color { get; set; }
    public int Year {  get; set; }

    //Əgər boş constructor ovveride edilməzsə və ya constructorların overload halı yazılmazsa arxa tərəfdə default(boş) constructorAssembly səviyyəsində generate edilib add edilir.

    public Vehicle(int year)
    {
        Year = year;

        _id++;
        Id = _id;
    }

    public Vehicle(string color, int year) : this(year)
    {
        Color = color;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine("Bu method Vehiclea aiddir.");
    }
}
