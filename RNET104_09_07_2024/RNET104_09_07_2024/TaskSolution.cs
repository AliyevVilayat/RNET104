namespace RNET104_09_07_2024;

public class TaskSolution
{
    public static string MethodExpression(int point)
    {
        string result = point switch
        {
            <= 100 and >= 91 => "A",
            <= 90 and >= 81 => "B",
            <= 80 and >= 71 => "C",
            <= 70 and >= 61 => "D",
            <= 60 and >= 51 => "E",
            <= 51 and >= 0 => "F",
            _ => "Wrong point"
        };


        return result;
    }

    public static string MethodCase(int point)
    {
        string result;

        switch (point)
        {
            case int p when p >= 91 && p <= 100:
                result = "A";
                break;

            case int p when (p >= 81 && p <= 90):
                result = "B";
                break;

            case int p when (p >= 71 && p <= 80):
                result = "C";
                break;
            case int p when (p >= 61 && p <= 70):
                result = "D";
                break;
            case int p when (p >= 51 && p <= 60):
                result = "E";
                break;
            case int p when (p >= 0 && p <= 50):
                result = "F";
                break;
            default:
                result = "Wrong point";
                break;
        }

        switch (point)
        {
            case >= 91 and <= 100:
                result = "A";
                return result;

            case >= 81 and <= 90:
                result = "A";
                break;

            default:
                result = "Wrong";
                break;
        }

        return result;
    }

}

public class NullCoalescingOperators
{
    public static void UseNullCoalescing()
    {
        int? nullableAge = null;
        int age;


        /* //Value property and Cast 
              if(nullableAge is not null)
                {
                    //age = nullableAge.Value;
                    age = (int)nullableAge;
                }
                else
                {
                    age = 18;
                }*/

        /* //GetValueOrDefault
        age = nullableAge.GetValueOrDefault();*/

        /* //Null Coalescing Operator ??

        age = nullableAge ?? 118;
        Console.WriteLine(age);*/

        /*//Null Coalescing Assignment Operator ??=

        nullableAge ??= 22;
        Console.WriteLine(nullableAge);*/


    }
}

public class VarDynamic
{
    public static void UseVar()
    {
        //Tip mənimsədilməsi Compile time olduğu üçün başqa bir tipdə dəyər mənimsətmək olmaz. Compile time error alırıq.

        //variable declare olan zaman dəyər mənimsədilməlidir. Əks təqdirdə Compile time error alırıq.


        var age = 5;

        //age = "Text"; compile time error
        //var num; compile time error
    }

    public static void UseDynamic()
    {
        //Tip mənimsədilməsi Runtime time olduğu üçün code gedişatı zamanı istənilən tip dəyər mənimsətmək mümkündür. 

        //variable declare olan zaman dəyər mənimsətməsək də olar.

        
        dynamic age = 5;

        age = "Text";
        dynamic test;
    }
}