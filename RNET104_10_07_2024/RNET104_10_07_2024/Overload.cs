using System.Drawing;

namespace RNET104_10_07_2024;




#region Notes

//Overload - 


//Operator Overload - overload prosesi static(keyword) olmalıdır, return type olaraq daxilində overload olduğu classın typeı seçilir .

#endregion
public class MyInt
{
    //Custom integer/
    public int Value { get; set; }

    public MyInt(int val1)
    {
        Value = val1;
    }

/*   
    public static MyInt Topla(MyInt obj1, MyInt obj2)
    {
        int val = obj1.Value+obj2.Value;
        MyInt c = new MyInt(val);
        return c;
        
    }*/

    public static MyInt operator +(MyInt obj1, MyInt obj2)
    {
        int val = obj1.Value - obj2.Value;
        //.......
        //.......
        Console.WriteLine("Siz az once toplama operatorunun overload halini istifade etdiniz");
        MyInt c = new MyInt(val);
        return c;

    }

}

public class Coordinate
{
    double X { get; set; }
    double Y { get; set; }

    public Coordinate(double x, double y)
    {
        X = x;
        Y = y;
    }

    public static Coordinate operator -(Coordinate a, Coordinate b)
    {
        Coordinate coordinate = new(a.X - b.X, a.Y - b.Y);
        return coordinate;
    }

    public static double Distance(Point p1, Point p2)
    {
        double deltaX = p2.X - p1.X;
        double deltaY = p2.Y - p1.Y;
        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    }
}

