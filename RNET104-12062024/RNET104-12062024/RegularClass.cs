namespace RNET104_12062024;

public class BaseClass
{

    //Heç bir constructor overloading və ya overriding(default constructor'un override'ı nəzərdə tutulur) olmazsa arxa tərəfdə Assembly səviyyəsində Default Constructor generate olunur.

    public int MyProperty { get; set; }

    public BaseClass(int value)
    {
        MyProperty = value;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine("There is news");
    }


}

public class DerivedClass : BaseClass
{
    public DerivedClass() : base(5)
    {
    }

    public override void ShowInfo()
    {
        Console.WriteLine("From Derived Class");
    }
}















public interface IInterface
{

}

public struct Point: IInterface
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public void ShowCurrentPoint()
    {
        Console.WriteLine($"x:{X} y:{Y}");
    }


}
