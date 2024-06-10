namespace RNET104_10062024_2;

public class Car:Vehicle
{

    public const double _currentFuel = 22;

    public string Brand { get; set; }
    public string Model { get; set; }
    public int FuelCapacity { get; set; }
    public double FuelFor1Km { get; set; }
    public double CurrentFuel { get; set; }


    public Car(int year,string brand, string model, int fuelCapacity, double fuelFor1Km):base(year:year)
    {
        Brand = brand;
        Model = model;
        FuelCapacity = fuelCapacity;
        FuelFor1Km = fuelFor1Km;
    }

    public Car(int year, string brand, string model, int fuelCapacity, double fuelFor1Km, double currentFuel):this(year,brand,model,fuelCapacity,fuelFor1Km)
    {
      
        CurrentFuel = currentFuel;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Id:{Id},Year:{Year},Brand:{Brand},Model:{Model},Fuel Capacity:{FuelCapacity},FuelFor1Km:{FuelFor1Km},Current Fuel:{CurrentFuel},");
    }

}
